//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

 //namespace Avtorizaciya
//{
   // public partial class Form4 : Form
  //  {
      //  public Form4()
     //   {
       //     InitializeComponent();
     //   }

      //  private void button1_Click(object sender, EventArgs e)
      //  {
       //     var login = textBox1.Text;
       //     var password = textBox2.Text;
       //
       //     string querystrng = $"insert into register(login_user, password_user) values('{login}', '{password}')";
       //
       //     SqlCommand command = new SqlCommand(querystrng, Trade.getConnection());
       //
       //     dataBase.openConnection();
       //     if (checkUser())
//
        //    {
        //        return;
        //    }

        //    if (command.ExecuteNonQuery() == 1)
         //   {
        //        MessageBox.Show("Аккаунт успешно создан", "Успех");
         //       authorization frm_login = new authorization();
         //       this.Hide();
        //        frm_login.ShowDialog();
        //    }
         //   else
        //    {
         //       MessageBox.Show("Аккаунт не создан");
        //    }

        //    dataBases.closeConnection();

     //   }

     //   private void Form4_Load(object sender, EventArgs e)
     //   {

     //   }
   // }
   // }
// }
