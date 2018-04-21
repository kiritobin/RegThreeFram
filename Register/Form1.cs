using Register.BLL;
using Register.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserInfo user = new UserInfo();
        UserInfoBLL userBll = new UserInfoBLL();
        public bool Insert { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            user.userName = textBox1.Text.Trim();
            user.password = textBox2.Text.Trim();
            if (user.userName == "")
            {
                MessageBox.Show("请输入用户名!");
                return;
            }
            if (user.password == "")
            {
                MessageBox.Show("请输入密码!");
                return;
            }
            int count = userBll.Login(user);
            if (count > 0)
            {
                MessageBox.Show("用户名已存在");
            }
            else
            {
                if (Insert == false)
                {
                    userBll.Insert(user);
                    MessageBox.Show("注册成功!");
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            }
        }
    }
}
