/*
 * Created by SharpDevelop.
 * User: chepchip
 * Date: 4/18/2017
 * Time: 12:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace TINH_TONG_2_SO___ANTT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;
		}
		
		private TCPModel tcp;
		private SocketModel[] socket = new SocketModel[100];
		private int soClientHienTai = 0;
        private int soClientJoinTable = 0; //Số client đã tham gia vào bàn chơi
        private Table[] table=new Table[10];
        private int soTableNow=0;//Đối tượng bàn trong game
        private int[] luotDanh = new int[4];//Kiểm tra lượt đánh của client
		public void KhoiDongServer(){			
			tcp = new TCPModel(textBox1.Text,int.Parse(textBox2.Text));
			button1.Enabled = false;
			tcp.Listen();		
		}
		
		public void ChapNhanKetNoi(){
			//chap nhan ket noi
			int status = -1;
			Socket s = tcp.SetUpANewConnection(ref status);
			socket[soClientHienTai] = new SocketModel(s);
			
			//cap nhat giao dien
			String str = "";
			str = str + socket[soClientHienTai].GetRemoteEndpoint();
			textBox3.AppendText(str);
			textBox3.Update();
			
			//tang so client dang phuc vu
			soClientHienTai ++;		
		}
		
		public void PhucVuYeuCau(Object obj){
			int index = (Int32) obj;
            //phuc vu client nhieu lan
            string CHECK = "";//đếm để vào vòng lặp if else tránh gửi bộ bài thêm lần nữa
            while (true) {
                //nhan yeu cau va cap nhat giao dien				
                string str1 = socket[index].ReceiveData(); //Nhan yeu cau tu client (switch..)
                string CheckString=index.ToString() + "_" + str1;//Cái đầu tiên là socket của client nào gửi ví dụ 0_join là socket 0
                textBox4.Text =index.ToString()+"_"+ str1;
                string[] arrStr = str1.Split('_');
                CHECK = arrStr[0];
                switch (CHECK)
                {
                    case "START":
                        {
                            Start();
                            break;
                        }
                    case "JOIN":
                        {
                            Join(index);
                            break;
                        }
                    case "DANH":
                        {
                            Danh(index, soClientHienTai, str1);
                            break;
                        }
                }               

            }
		}
        void Danh(int index,int soclient,string arr)
        {
            string str = "DANH_" + index + '_';
            for(int i = 0; i < soclient; i++)
            {
                if (index != i)
                {
                    socket[i].SendData(str + arr);
                }
            }
        }
        void Join(int index)
        {
            for(int i = 0; i < index; i++)
            {
                socket[i].SendData("JOIN");
            }

        }
        void Start()
        {
            CardSet cardSet = new CardSet(); //tao bo bai
            Random random = new Random();
            Boolean duplicate = false; //bien kt random trung
            int[] arr = new int[52]; //Tao mang 52 phan tu de luu nhung so random
            string data1 = "START_";
            string data2 = "START_";
            string data3 = "START_";
            string data4 = "START_";
            for (int i = 0; i < 52; i++)
            {
                do
                {
                    duplicate = false;
                    int j = random.Next(1, 53); //random 1 so, kt so do co chua, neu co roi thi random lai
                    if (Timx(arr, j) == false)
                    {
                        if (i < 13)
                        {
                            data1 += cardSet.output(cardSet.GetCard(j - 1));
                        }
                        else
                        if (i < 26)
                        {
                            data2 += cardSet.output(cardSet.GetCard(j - 1));
                        }
                        else
                        if (i < 39)
                        {
                            data3 += cardSet.output(cardSet.GetCard(j - 1));
                        }
                        else
                        {
                            data4 += cardSet.output(cardSet.GetCard(j - 1));
                        }
                        arr[i] = j;
                        duplicate = true;
                    }
                }
                while (duplicate == false);
            }

            if (soClientHienTai == 4)
            {
                socket[0].SendData(data1);
                socket[1].SendData(data2);
                socket[2].SendData(data3);
                socket[3].SendData(data4);

            }
            else if (soClientHienTai == 3)
            {
                socket[0].SendData(data1);
                socket[1].SendData(data2);
                socket[2].SendData(data3);
            }
            else if (soClientHienTai == 2)
            {
                socket[0].SendData(data1);
                socket[1].SendData(data2);
            }
            else //th nay khong cho phep..de test thoi
            {
                socket[0].SendData(data1);
            }
        }
		public void UpdateTablePlayer(int soClientHienTai)
        {
            int z = 0;
            if (z == 0)
            {
                table[soTableNow] = new Table();
                table[soTableNow].SetSoPlayer(soClientJoinTable+1);
                soClientJoinTable += 1;
                z = 1;
            }
            else { table[soTableNow].Update1Player(); }
            if (table[soTableNow].GetSoPlayer() > 4)
            {
                table[soTableNow + 1].Update1Player();
                soTableNow += 1;
            }
            string data;
            data = "TABLE" + '_' + table[soTableNow].GetSoThuTuTable().ToString() + table[soTableNow].GetSoPlayer().ToString();
            socket[soClientHienTai - 1].SendData(data);
        }
        public void SendDataPlayer(int soclient,int socketGui)
        {
            for(int i = 0; i < soclient; i++)
            {
                string str = "UPDATETABLE" + '_' + i;
              
            }
        }
		public void MultiScript(){
			//Phuc vu nhieu PHIEN client
			while (true){
				//Step 2.1: Cho va chap nhan ket noi tu client
				ChapNhanKetNoi();
                UpdateTablePlayer(soClientHienTai);
				//Step 2.2: Phuc vu yeu cau	
				Thread t = new Thread(PhucVuYeuCau);
				t.Start(soClientHienTai-1);			
			}		
		}
		//Hàm nhận dạng kiểu đánh bài 
        int KiemTraNuocDanhHopLe(string data)
        {
            string strCheck = "";
            
            string[] arrStrings = data.Split('_');
            Card[] arrCards = new Card[arrStrings.Length - 1];
            for(int i = 0; i < arrCards.Length; i++)
            {
                arrCards[i].input(arrStrings[i + 1]);
            }
            switch (strCheck)
            {
                case "DOI":
                    {
                        if (arrCards[0].GetGt() == arrCards[1].GetGt())
                        {
                            return 1;
                        }
                        else { return 0; }                                              
                    }
                    
                case "SANH":
                    {

                    }
                    break;
            }
            return 0;
        }
		void Button1Click(object sender, EventArgs e)
		{
			//Step 1: Bat server
			KhoiDongServer();			
			//Step 2: Chap nhan ket noi va phuc vu yeu cau
			//--- Phai bo vao thread vi step 2.1 se lam treo may (doi client moi ket noi) ---//
			Thread t = new Thread(MultiScript);
			t.Start();
		}
        public bool Timx(int[] a, int x)
        {
            for (int i = 0; i < 52; i++)
            {
                if (a[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
