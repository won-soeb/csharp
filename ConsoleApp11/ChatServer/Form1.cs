﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ChatServer
{
    delegate void SetTextCallback(string s);

    public partial class Form1 : Form
    {
        TcpListener lit_Listener =
        new TcpListener(IPAddress.Parse("192.168.0.220"), 5001);
        public static ArrayList soketArray = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        public void SetText(string text)
        {
            if (this.txt_Chat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); 
                this.Invoke(d, new object[] { text }); 
            }
            else
            {
                this.txt_Chat.AppendText(text);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            lit_Listener.Stop();
        }
        private void cmd_Start_Click(object sender, EventArgs e)
        {
            if (lbl_Message.Tag.ToString() == "Stop")
            {
                //Listener Start
                lit_Listener.Start();
                //Client로 부터 연결을 기다리는 Thread생성
                Thread thd_WaitSocket = new Thread(new ThreadStart(Wait_Socket));
                thd_WaitSocket.Start();
                lbl_Message.Text = "Server Start 상태 입니다.";
                lbl_Message.Tag = "Start";
                cmd_Start.Text = "Server Stop";
            }
            else
            {
                lit_Listener.Stop();
                foreach (Socket soket in Form1.soketArray)
                {
                    soket.Close();
                }
                Form1.soketArray.Clear();
                lbl_Message.Text = "Server Stop 상태 입니다.";
                lbl_Message.Tag = "Stop";
                cmd_Start.Text = "Server Start";
            }
        }
        private void Wait_Socket()
        {
            Socket sktClient = null;
            while (true)
            {
                //Socket 생성 및 연결 대기
                try
                {
                    //Client 연결을 기다린다.
                    sktClient = lit_Listener.AcceptSocket();
                    //Chatting을 실행하는 Class 인스턴스화시키고 Socket 할당
                    Chat_Class cht_Class = new Chat_Class();
                    cht_Class.Chat_Class_Setup(this, sktClient, this.txt_Chat);
                    //Chatting을 실행하는Thread 생성
                    Thread thd_ChatProcess = new Thread(new
                   ThreadStart(cht_Class.Chat_Process));
                    thd_ChatProcess.Start();
                }
                catch (System.Exception)
                {
                    Form1.soketArray.Remove(sktClient); break;
                }
            }
        }
    }

    public class Chat_Class
    {
        //한글 처리를 위해 Encod 정의
        private Encoding ecd_Encode = Encoding.GetEncoding("KS_C_5601-1987");
        //글자를 Display할 Object
        private System.Windows.Forms.TextBox txt_Chat;
        private Socket sktClient;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;
        public void Chat_Class_Setup(Form1 form1, Socket sktClient,
       System.Windows.Forms.TextBox txt_Chat)
        { //TextBox를 할당함.
            this.txt_Chat = txt_Chat; //Socket 을 할당함.
            this.sktClient = sktClient; //Network Stream을 생성
            this.netStream = new NetworkStream(sktClient);
            Form1.soketArray.Add(sktClient); //Stream Reader을 생성
            this.strReader = new StreamReader(netStream, ecd_Encode);
            this.form1 = form1;
        }
        public void Chat_Process()
        {
            while (true)
            {
                try
                {
                    //문자열을 받음
                    string lstMessage = strReader.ReadLine();
                    if (lstMessage != null && lstMessage != "")
                    {               
                        form1.SetText(lstMessage + "\r\n");

                        byte[] bytSand_Data = Encoding.Default.GetBytes(lstMessage + "\r\n");
                        ArrayList remove_soketArray = new ArrayList();
                        lock (Form1.soketArray)
                        {
                            foreach (Socket soket in Form1.soketArray)
                            {
                                NetworkStream stream = new NetworkStream(soket); stream.Write(bytSand_Data, 0,
                              bytSand_Data.Length);
                            }
                        }
                    }
                }
                catch (System.Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Form1.soketArray.Remove(sktClient);
                    break;
                }
            }
        }
    }
}
