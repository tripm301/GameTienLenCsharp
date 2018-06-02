using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace TINH_TONG_2_SO___ANTT
{
    class Table
    {
        int soThuTu;
        int soPlayer;
        SocketModel[] arrSocket = new SocketModel[4];
        public Table()
        {
            soThuTu = 0;
            soPlayer = 0;
        }
        //Cập nhật socket khi có client mới join bàn chơi
        void UpdateSocketTable(Socket a)
        {
            SocketModel tem = new SocketModel(a);
            int vitri = soPlayer - 1;
            arrSocket[vitri] = tem;
        }
        //get table
        public int GetSoThuTuTable()
        {
            return this.soThuTu;
        }
        public int GetSoPlayer()
        {
            return this.soPlayer;
        }
        //set table
        public void SetSoThuTu(int a)
        {
            this.soThuTu = a;
        }
        public void SetSoPlayer(int a)
        {
            this.soPlayer = a;
        }
        public Table Update1Player()
        {
            this.soPlayer = this.soPlayer + 1;
            return this;
        }
        public Table ConverTable(string data)
        {
            Table table = new Table();
            string soPlayer = data.Substring(data.Length - 1);
            string soThuTu = data.Substring(0, data.Length - 1);
            table.SetSoThuTu(int.Parse(soThuTu));
            table.SetSoPlayer(int.Parse(soPlayer));
            return table;
        }
        public string GetString()
        {
            return this.soThuTu.ToString() + '_' + this.soPlayer.ToString();
        }
    }
}
