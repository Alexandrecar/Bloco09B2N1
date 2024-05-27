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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //comando a ser incrementado com os filtros
                string basica = "SELECT e.cod_equipamento 'Equipamento', marcas_equip.descr_marca 'Marca', modelos_equip.descr_modelo 'Modelo', descricoes_equip.descricao 'Descrição', e.num_patrimonio 'Num Patrimonio', e.serialNum 'Código', e.cod_sap 'Cod Sap', locais.descr_local 'Local', status_equip.descr_status 'Status'FROM equipamentos e\r\nINNER JOIN marcas_equip ON marcas_equip.cod_marca = e.cod_marca\r\nINNER JOIN modelos_equip ON modelos_equip.cod_modelo = e.cod_modelo\r\nINNER JOIN descricoes_equip ON descricoes_equip.cod_descr = e.cod_descr\r\nINNER JOIN locais ON locais.cod_local = e.cod_local\r\nINNER JOIN status_equip ON status_equip.cod_status = e.cod_status \r\nWHERE e.cod_marca = e.cod_marca";
                //array das combobox para o filtro com valores int no banco de dados
                ComboBox[] campos = new ComboBox[7];
                campos[0] = cod_marca;
                campos[1] = cod_modelo;
                campos[2] = cod_descr;
                campos[3] = num_patrimonio;
                campos[4] = cod_status;
                campos[5] = cod_sap;
                campos[6] = cod_local;

                //incremento dos filtros caso a combobox nao esteja vazia com valor int no banco de dados
                for (int i = 0; i < campos.Length; i++)
                {
                    if (campos[i].SelectedIndex != -1)
                    {
                        basica = basica + string.Format(" AND e.{0} = {1}", campos[i].Name, campos[i].SelectedValue);
                    }
                }
                //incremento do filtro para varchar no banco de dados
                if (serialNum.SelectedIndex != -1)
                {
                    basica = basica + string.Format(" AND e.serialNum LIKE '{0}'", serialNum.SelectedValue);
                }

                string comandof = basica + ";";

                lv(lv_consulta, comandof);
            }
            catch 
            {
                MessageBox.Show("Preenchimento inválido, verifique os campos preenchidos.", "AVISO!", MessageBoxButtons.OK);
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            lv(lv_consulta, "SELECT e.cod_equipamento 'Equipamento', marcas_equip.descr_marca 'Marca', modelos_equip.descr_modelo 'Modelo', descricoes_equip.descricao 'Descrição', e.num_patrimonio 'Num Patrimonio', e.serialNum 'Código', e.cod_sap 'Cod Sap', locais.descr_local 'Local', status_equip.descr_status 'Status'\r\nFROM equipamentos e\r\nINNER JOIN marcas_equip ON marcas_equip.cod_marca = e.cod_marca\r\nINNER JOIN modelos_equip ON modelos_equip.cod_modelo = e.cod_modelo\r\nINNER JOIN descricoes_equip ON descricoes_equip.cod_descr = e.cod_descr\r\nINNER JOIN locais ON locais.cod_local = e.cod_local\r\nINNER JOIN status_equip ON status_equip.cod_status = e.cod_status;");
        }

        private void lv_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cod_marca_DropDown(object sender, EventArgs e)
        {
            cb(cod_marca, "marcas_equip", "descr_marca", "cod_marca");
        }

        private void cod_modelo_DropDown(object sender, EventArgs e)
        {
            cb(cod_modelo, "modelos_equip", "descr_modelo", "cod_modelo");
        }

        private void cod_descr_DropDown(object sender, EventArgs e)
        {
            cb(cod_descr, "descricoes_equip", "descricao", "cod_descr");
        }

        private void num_patrimonio_DropDown(object sender, EventArgs e)
        {
            cb(num_patrimonio, "equipamentos", "num_patrimonio", "num_patrimonio");
        }

        private void serialNum_DropDown(object sender, EventArgs e)
        {
            cb(serialNum, "equipamentos", "serialNum", "serialNum");
        }

        private void cod_sap_DropDown(object sender, EventArgs e)
        {
            cb(cod_sap, "equipamentos", "cod_sap", "cod_sap");
        }

        private void cod_local_DropDown(object sender, EventArgs e)
        {
            cb(cod_local, "locais", "descr_local", "cod_local");
        }

        private void cod_status_DropDown(object sender, EventArgs e)
        {
            cb(cod_status, "status_equip", "descr_status", "cod_status");
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }
    }
}
