using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn.NetMVC.Models
{
    public class Global
    {
        public static string ConnectionString = @"Data Source=DESKTOP-UUV7A6H\SQLEXPRESS;Initial Catalog=IM;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static IMDataContext context = new IMDataContext(ConnectionString);
        public static TaiKhoan GetUser(string username)
        {
            return context.TaiKhoans.FirstOrDefault(x => x.MaNguoiDung == username);
        }
    }
}