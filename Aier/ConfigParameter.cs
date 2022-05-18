using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Interceptor;
using System.Threading;

namespace Aier
{
    
    public partial class ConfigParameter : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtConfig = new DataTable();
        DataTable dtTest = new DataTable();
        public ConfigParameter()
        {
            InitializeComponent();
        }

        private void ConfigParameter_Load(object sender, EventArgs e)
        {
            string query = "Select * from Config";
            string query1 = "Select * from TestLibrary";

            objDBAccess.readDatathroughAdapter(query, dtConfig);
            objDBAccess.readDatathroughAdapter(query1, dtTest);

            dataGridView1.DataSource = dtConfig;
            dataGridView2.DataSource = dtTest;
            objDBAccess.closeConn();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string query = "Select * from OCRHistory";

            int changes = objDBAccess.executeDataAdapter(dtConfig, query);


        }

        private void btn_Optmize_Click(object sender, EventArgs e)
        {
            Input input = new Input();

            // Be sure to set your keyboard filter to be able to capture key presses and simulate key presses
            // KeyboardFilterMode.All captures all events; 'Down' only captures presses for non-special keys; 'Up' only captures releases for non-special keys; 'E0' and 'E1' capture presses/releases for special keys
            input.KeyboardFilterMode = KeyboardFilterMode.All;
            // You can set a MouseFilterMode as well, but you don't need to set a MouseFilterMode to simulate mouse clicks

            // Finally, load the driver
            input.Load();

            input.MoveMouseTo(5, 5);  // Please note this doesn't use the driver to move the mouse; it uses System.Windows.Forms.Cursor.Position
            input.MoveMouseBy(25, 25); //  Same as above ^
            input.SendLeftClick();

            //input.KeyDelay = 1; // See below for explanation; not necessary in non-game apps
            input.SendKeys(Interceptor.Keys.Enter);  // Presses the ENTER key down and then up (this constitutes a key press)

            // Or you can do the same thing above using these two lines of code
            input.SendKeys(Interceptor.Keys.Enter);
            Thread.Sleep(1); // For use in games, be sure to sleep the thread so the game can capture all events. A lagging game cannot process input quickly, and you so you may have to adjust this to as much as 40 millisecond delay. Outside of a game, a delay of even 0 milliseconds can work (instant key presses).
            input.SendKeys(Interceptor.Keys.Enter);

            input.SendText("hello, I am typing!");

            /* All these following characters / numbers / symbols work */
            input.SendText("abcdefghijklmnopqrstuvwxyz");
            input.SendText("1234567890");
            input.SendText("!@#$%^&*()");
            input.SendText("[]\\;',./");
            input.SendText("{}|:\"<>?");


            // And finally
            input.Unload();
        }

        private void config_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void textBox_scope2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //int i = 74;
            //if (i >= textBox_scope1.Text) ;

            //if (i < textBox_scope2.Text) ;

            int ConfigTestValue;
            int ConfigMinValue;
            int ConfigMaxValue;
            int IntervalValue;

            //IntervalValue
            int.TryParse(textBox_Interval.Text, out IntervalValue);
            //ConfigTestValue
            int.TryParse(textBox_scope1.Text,out ConfigMinValue);//still need to do null check.
            if (ConfigMinValue != null) ;
                ConfigTestValue = ConfigMinValue + IntervalValue;
            //ConfigMaxValue;
            int.TryParse(textBox_scope2.Text, out ConfigMaxValue);
            if (ConfigMaxValue != null) ;
                ConfigTestValue = ConfigMaxValue + IntervalValue;


            




        }
    }
}
