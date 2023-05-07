using Game_Kursak_Admin.model;
using Game_Kursak_Admin.model.DB_Model;
using Game_Kursak_Admin.view;
using Newtonsoft.Json;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Game_Kursak_Admin.controller
{
    internal class Controller
    {
        public SimpleTcpServer server;
        public MyServer server_paraments = new MyServer();
        AdminModel db = new AdminModel();
        List<Player_statistics_for_client> saveResults = new List<Player_statistics_for_client>();

        public void StopServer(Button btn_stop_server, Button btn_start_server)
        {
            server.Stop();
            server.Dispose();
            //server_paraments.CloseServer();
            btn_stop_server.Enabled = false;
            btn_start_server.Enabled = true;
        }

        public void StartServer(Button btn_stop_server, Button btn_start_server)
        {
            server.Start();
            btn_stop_server.Enabled = true;
            btn_start_server.Enabled = false;
        }

        public void AddToDB(string json)
        {
            bool flag = false;
            bool flag_ban = false;
            List<Player_statistics_for_client> list_result_client = new List<Player_statistics_for_client>();
            list_result_client = JsonConvert.DeserializeObject<List<Player_statistics_for_client>>(json);
            foreach (var item in list_result_client)
            {
                foreach (var item2 in db.Bans)
                {
                    if (item2.PC_Name_And_ID.Id_PC == item.for_Id_PC)
                    {
                        flag_ban = true;
                    }
                }
               
            }
            if (flag_ban != true)
            {
                #region add_PC_Name_And_ID
                string ip_pc = "";
                int id_PC_Name_ID = 0;
                foreach (var item_clients in list_result_client)
                {
                    ip_pc = item_clients.for_Id_PC;
                    foreach (var item in db.PC_Name_And_ID)
                    {
                        if (item.Id_PC == ip_pc)
                        {
                            id_PC_Name_ID = item.Id;
                            break;
                        }
                    }
                    if (id_PC_Name_ID == 0)
                    {
                        db.PC_Name_And_ID.Add(new PC_Name_And_ID() { Name_PC = item_clients.for_Name_PC, Id_PC = item_clients.for_Id_PC });
                        db.SaveChanges();
                    }
                }

                #endregion
                #region add_Spent_ammo
                int ammo_picked_up = 0;
                int fired_bullets = 0;
                int id_Spent_ammo = 0;
                foreach (var item_spent_ammo_client in list_result_client)
                {
                    ammo_picked_up = item_spent_ammo_client.for_client_Ammo_picked_up;
                    fired_bullets = item_spent_ammo_client.for_client_Fired_bullets;
                    foreach (var item in db.Spent_ammo)
                    {
                        if (item.Ammo_picked_up == ammo_picked_up && item.Fired_bullets == fired_bullets)
                        {
                            id_Spent_ammo = item.ID;
                            break;
                        }
                    }
                    if (id_Spent_ammo == 0)
                    {
                        db.Spent_ammo.Add(new Spent_ammo() { Ammo_picked_up = item_spent_ammo_client.for_client_Ammo_picked_up, Fired_bullets = item_spent_ammo_client.for_client_Fired_bullets });
                        db.SaveChanges();
                    }
                }


                #endregion
                #region add_Med_kit
                int med_kit_picked_up = 0;
                int hP_replenishment_amount = 0;
                int id_Med_kit = 0;
                foreach (var item in list_result_client)
                {
                    med_kit_picked_up = item.for_client_Med_kit_picked_up;
                    hP_replenishment_amount = item.for_client_HP_replenishment_amount;
                    foreach (var item2 in db.Med_kit)
                    {
                        if (item2.Med_kit_picked_up == med_kit_picked_up && item2.HP_replenishment_amount == hP_replenishment_amount)
                        {
                            id_Med_kit = item2.ID;
                            break;
                        }
                    }
                    if (id_Med_kit == 0)
                    {
                        db.Med_kit.Add(new Med_kit() { Med_kit_picked_up = item.for_client_Med_kit_picked_up, HP_replenishment_amount = item.for_client_HP_replenishment_amount });
                        db.SaveChanges();
                    }

                }


                #endregion
                #region add_Player_statistics
                foreach (var item in list_result_client)
                {
                    foreach (var item2 in db.Player_statistics)
                    {
                        if (item2.PC_ID_And_Name_Id == id_PC_Name_ID)
                        {
                            if (item.for_client_Kills > item2.Kills)
                            {
                                item2.Nick_name = item.for_client_NickName;
                                item2.Kills = item.for_client_Kills;
                                item2.Spent_ammo_id = id_Spent_ammo;
                                item2.Med_kit_id = id_Med_kit;
                                item2.Weapon_id = 2;
                                item2.Game_time = item.for_client_Game_time;
                                //db.Entry(item2).State = EntityState.Modified;
                                
                                flag = true;
                                break;
                            }
                            else
                            {
                                flag = true;
                                break;
                            }
                            
                        }
                    }
                    //db.SaveChanges();
                    if (flag != true)
                    {
                        db.Player_statistics.Add(new Player_statistics()
                        {
                            PC_ID_And_Name_Id = id_PC_Name_ID,
                            Nick_name = item.for_client_NickName,
                            Kills = item.for_client_Kills,
                            Spent_ammo_id = id_Spent_ammo,
                            Med_kit_id = id_Med_kit,
                            Weapon_id = 2,
                            Game_time = item.for_client_Game_time
                        });
                        //db.SaveChanges();
                    }
                    else { break; }
                }
                db.SaveChanges();
                #endregion
            }

        }

        public void DeleteFromDB(string id_str)
        {
            try
            {
                int id = Convert.ToInt32(id_str);
                Player_statistics character = db.Player_statistics.Where(x => x.Id == id).FirstOrDefault();
                db.Player_statistics.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); }
        }

        public void DeleteFromBan(string id_str)
        {
            try
            {
                int id = Convert.ToInt32(id_str);
                Ban character = db.Bans.Where(x => x.Id == id).FirstOrDefault();
                db.Bans.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); }
        }

        public void ShowDB(DataGridView dataGridView_Results, DataGridView dataGridView_Ban)
        {
            try
            {
                DataTable dt_Player_statistics = new DataTable();
                dt_Player_statistics.Columns.Add("Id", typeof(int));
                dt_Player_statistics.Columns.Add("IP adress", typeof(string));
                dt_Player_statistics.Columns.Add("Nick name", typeof(string));
                dt_Player_statistics.Columns.Add("Kills", typeof(int));
                dt_Player_statistics.Columns.Add("Ammo picked up", typeof(int));
                dt_Player_statistics.Columns.Add("Fired bullets", typeof(int));
                dt_Player_statistics.Columns.Add("Med kit picked up", typeof(int));
                dt_Player_statistics.Columns.Add("HP replenishment amount", typeof(int));
                dt_Player_statistics.Columns.Add("Game time", typeof(string));

                foreach (var item in db.Player_statistics)
                {
                    dt_Player_statistics.Rows.Add
                        (
                            item.Id,
                            item.PC_Name_And_ID.Id_PC,
                            item.Nick_name, 
                            item.Kills, 
                            item.Spent_ammo.Ammo_picked_up, 
                            item.Spent_ammo.Fired_bullets, 
                            item.Med_kit.Med_kit_picked_up,
                            item.Med_kit.HP_replenishment_amount, 
                            item.Game_time
                        );
                }

                dataGridView_Results.DataSource = dt_Player_statistics;

                DataTable dt_Player_Bans = new DataTable();

                dt_Player_Bans.Columns.Add("Id", typeof(int));
                dt_Player_Bans.Columns.Add("Name PC", typeof(string));
                dt_Player_Bans.Columns.Add("IP adress", typeof(string));

                foreach (var item in db.Bans)
                {
                    dt_Player_Bans.Rows.Add(item.Id, item.PC_Name_And_ID.Name_PC, item.PC_Name_And_ID.Id_PC);
                }

                dataGridView_Ban.DataSource = dt_Player_Bans;
            }
            catch { MessageBox.Show("Cannot Show Table from DB"); }
        }

        public void AddToBan(string IP_PC)
        {
            try
            {
                int id = 0;
                foreach (var item in db.Player_statistics)
                {
                    if (item.PC_Name_And_ID.Id_PC == IP_PC)
                    {
                        db.Bans.Add(new Ban() {PC_ID_And_Name_Id = item.PC_ID_And_Name_Id});
                        id = (int)item.PC_ID_And_Name_Id;
                    }
                }
                Player_statistics character = db.Player_statistics.Where(x => x.PC_ID_And_Name_Id == id).FirstOrDefault();
                db.Player_statistics.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку IP adress с которую хотите удалить!"); }
        }

        public void AuthorizationCheck(string login, string password, LoginForm form, FormAdmin formAdmin)
        {
            foreach (var item in db.Admins)
            {
                if (login == item.Login && password == item.Password)
                {
                    formAdmin.Show();
                    form.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password or login");
                }
            }
           
        }

        public string ConverDBtoJson()
        {
            List<Player_statistics_for_client> saveResults = new List<Player_statistics_for_client>();
            string json;
            foreach (var item in db.Player_statistics)
            {
                saveResults.Add(new Player_statistics_for_client(item.PC_Name_And_ID.Name_PC, item.PC_Name_And_ID.Id_PC, item.Nick_name, item.Kills, item.Spent_ammo.Ammo_picked_up, item.Spent_ammo.Fired_bullets, item.Med_kit.Med_kit_picked_up, item.Med_kit.HP_replenishment_amount, item.Game_time));
            }
            json = JsonConvert.SerializeObject(saveResults, Formatting.Indented);
            return json;
        }



    }
}
