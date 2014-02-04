using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            SetLogin();
        }

        private void SetLogin() {
            try {
                FormLogIn frm = new FormLogIn();
                DialogResult rst = frm.ShowDialog();
                if (rst == System.Windows.Forms.DialogResult.OK) {
                    
                } else {

                }
                frm.Close();
            } catch (Exception) {

            }
        }

        private void SetMenus() {




        }

        private void mnuClose_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
