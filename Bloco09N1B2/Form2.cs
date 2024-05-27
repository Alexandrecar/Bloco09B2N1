using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco09N1B12B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static DataTable conecta(String querry)
        {
            //Realizar a conexão
            SqlConnection conexao = new SqlConnection("Data source= localhost; Initial catalog= Bloco09; User ID= sa; Password= 123456");
            //Realizar a consulta
            SqlDataAdapter nova_consulta = new SqlDataAdapter(querry, conexao);
            //Manipular os dados
            DataTable tabela = new DataTable();
            nova_consulta.Fill(tabela); //Preenche o datatable com as colunas e linhas da consulta realizada
            return tabela;
        }

        public static void cb(ComboBox cb, String tabela, String col1, String col2)
        {
            //metodo usado para configurar combobox, parametros: combobox, tabela, coluna exibida, coluna utilizada pelo codigo
            cb.DataSource = conecta("SELECT " + col1 + ", " + col2 + " FROM " + tabela + ";");
            cb.DisplayMember = col1;
            cb.ValueMember = col2;
        }

        public static void lv(ListView lv, String querry)
        {
            //cria tabela com o comando desejado
            DataTable tabelalv = conecta(querry);
            //Remove os itens anteriores do listview
            lv.Items.Clear();
            lv.Columns.Clear();
            //adiciona as colunas vazias
            for (int i = 0; i < tabelalv.Columns.Count; i++)
            {
                lv.Columns.Add(tabelalv.Columns[i].ColumnName);
            }
            //insere os valores da tabela no listview
            foreach (DataRow elemento in tabelalv.Rows)
            {
                ListViewItem novo_item = new ListViewItem(elemento[0].ToString());

                for (int i = 1; i < tabelalv.Columns.Count; i++)
                {
                    novo_item.SubItems.Add(elemento[i].ToString());
                }
                lv.Items.Add(novo_item);
            }
            //redimensiona o listview
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public class AutoClosingMessageBox
        {
            //messagebox que fecha sozinha após certo tempo
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void grp_adicionar2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_adicionar2_Click(object sender, EventArgs e)
        {
            try
            { //Realizar a conexão
                SqlConnection conexaoc = new SqlConnection("Data source= localhost; Initial catalog= Bloco09; User ID= sa; Password= 123456");
                //Realizar a consulta do ultimo cod_equipamento
                string instrucao = "INSERT INTO equipamentos\r\n(cod_marca, cod_modelo, cod_descr, num_patrimonio, serialNum, cod_sap, cod_local, cod_status) VALUES\r\n({0},{1},{2},{3}, '{4}' ,{5},{6},{7});";
                instrucao = string.Format(instrucao, cb_marca2.SelectedValue,
                                                     cb_modelo2.SelectedValue,
                                                     cb_descricao2.SelectedValue,
                                                     txt_pat.Text,
                                                     txt_codigo.Text,
                                                     txt_sap.Text,
                                                     cb_local2.SelectedValue,
                                                     cb_status2.SelectedValue); //Atribui as variáveis aos placeholders
                conexaoc.Open();//Reabilita a conexão
                SqlCommand comando = new SqlCommand(instrucao, conexaoc);
                comando.ExecuteNonQuery();//executa o comando
                conexaoc.Close();//Encerra a conexão
                AutoClosingMessageBox.Show("ADICIONADO COM SUCESSO", "SUCESSO", 1000);
            }
            catch 
            {
                MessageBox.Show("Preenchimento inválido, verifique os campos preenchidos.", "AVISO!", MessageBoxButtons.OK);
            }
        }

        private void cb_marca2_DropDown(object sender, EventArgs e)
        {
            cb(cb_marca2, "marcas_equip", "descr_marca", "cod_marca");
        }

        private void cb_modelo2_DropDown(object sender, EventArgs e)
        {
            cb(cb_modelo2, "modelos_equip", "descr_modelo", "cod_modelo");
        }

        private void cb_descricao2_DropDown(object sender, EventArgs e)
        {
            cb(cb_descricao2, "descricoes_equip", "descricao", "cod_descr");
        }

        private void cb_local2_DropDown(object sender, EventArgs e)
        {
            cb(cb_local2, "locais", "descr_local", "cod_local");
        }

        private void cb_status2_DropDown(object sender, EventArgs e)
        {
            cb(cb_status2, "status_equip", "descr_status", "cod_status");
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
