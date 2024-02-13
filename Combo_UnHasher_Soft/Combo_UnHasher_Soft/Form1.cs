using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using RelyUI.Controls;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using Json;

namespace Combo_UnHasher_Soft
{
    public partial class Form1 : RelyForm
    {
        List<string> UserList;
        List<string> PassList;
        int Good; int Bad; int Error;
        int number;
        string[] API;
        public Form1()
        {
            InitializeComponent();
        }
        private void Config(string USER, string PASS)//CONFIG
        {
            try
            {     
                WebClient Find = new WebClient();

                string Get_API = $"http://www.nitrxgen.net/md5db/{PASS}.json";
                Find.Headers[HttpRequestHeader.ContentType] = "application/json";
                //Find.Headers[HttpRequestHeader.Host] = "bluecode.info";
                Find.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
                string Respone = Find.DownloadString(Get_API);
                dynamic Json_API = JsonParser.FromJson(Respone);

                if (Respone.Contains("found\":true"))
                {
                    Good++;
                    Good_lBL.Invoke(new MethodInvoker(delegate { Good_lBL.Text = Good.ToString(); }));

                    //Match FindHash = Regex.Match(Respone, $"\"ok\":true,\"private\":false,\"{PASS}\":\"(.*?)\"");
                    string Hash = Json_API["result"]["pass"];

                    Hits_List.Invoke(new MethodInvoker(delegate { Hits_List.Rows.Add($"{USER}", $"{Hash}"); }));
                    StreamWriter Sw = new StreamWriter("COMBO--[-AGC007-].TXT", true);
                    Sw.WriteLine($"{USER}:{Hash}"); Sw.Close();
                    Application.DoEvents();
                } 
                else
                {
                    Bad++;
                    Bad_lBL.Invoke(new MethodInvoker(delegate { Bad_lBL.Text = Bad.ToString(); }));
                    Application.DoEvents();
                }
            }
            catch
            {
                Error++; number--;
                Error_lBL.Invoke(new MethodInvoker(delegate { Error_lBL.Text = Error.ToString(); }));
                Application.DoEvents();
            }
            Check_lBL.Invoke(new MethodInvoker(delegate { Check_lBL.Text = Bad.ToString(); }));
            
        }
        private void ComboList()//COMBO LIST
        {
            try
            {
                OpenFileDialog OpenCombo = new OpenFileDialog();
                OpenCombo.Filter = "Select ComboList |*.txt";
                OpenCombo.Multiselect = false;
                OpenCombo.Title = "Select Your ComboList";

                if (OpenCombo.ShowDialog() == DialogResult.OK)
                {
                    StreamReader Sr = new StreamReader(OpenCombo.FileName);
                    UserList = new List<string>(); PassList = new List<string>();
                    while (!Sr.EndOfStream)
                    {
                        string txt = Sr.ReadLine();
                        char[] Sp_list = { ':' };
                        string[] Combo = txt.Split(Sp_list);
                        UserList.Add(Combo[0]);
                        PassList.Add(Combo[1]);
                    }
                    Sr.Close();
                    Combo_BTN.Text = "Combo: " + UserList.Count.ToString();
                }
            }
            catch
            { MessageBox.Show("Error To Load Your ComboList."); }
        }       
        private void MyThread()//Thread
        {
            int ThreadNumber = Convert.ToInt32(1000);
            ThreadPool.SetMinThreads(ThreadNumber, ThreadNumber);
            ThreadPool.SetMaxThreads(ThreadNumber, ThreadNumber);
            for (; number <= UserList.Count; number++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate { try { Config(UserList[number], PassList[number]); } catch { } }));
                Thread.Sleep(100); Application.DoEvents();
            }
        }
        private void Combo_BTN_Click(object sender, EventArgs e)//LOAD COMBO
        { ComboList(); }
        private void START_BTN_Click(object sender, EventArgs e)//START
        { MyThread(); }
        private void STOP_BTN_Click(object sender, EventArgs e)//STOP
        { ThreadPool.SetMinThreads(0, 0); ThreadPool.SetMaxThreads(0, 0); Application.DoEvents(); }
    }
}
