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
using static Bloco09N1B12B.Form2;

namespace Bloco09N1B12B
{
    public partial class Form4 : Form
    {
        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {
            bt_deletar2.Hide();
        }

        private void bt_voltar2_Click(object sender, EventArgs e)
        {
            //retorna ao forms1
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void bt_deletar2_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txt_codigo3.Text;

                //Realizar a conexão
                SqlConnection conexaoc = new SqlConnection("Data source= localhost; Initial catalog= Bloco09; User ID= sa; Password= 123456");
                //Realizar a consulta do ultimo cod_equipamento
                string instrucao = "DELETE FROM equipamentos WHERE serialNum LIKE '{0}';";
                instrucao = string.Format(instrucao, codigo); //Atribui as variáveis aos placeholders
                conexaoc.Open();//Reabilita a conexão
                SqlCommand comando = new SqlCommand(instrucao, conexaoc);
                comando.ExecuteNonQuery();//executa o comando
                conexaoc.Close();//Encerra a conexão

                bt_deletar2.Hide();
                //mensagem de sucesso
                AutoClosingMessageBox.Show("REMOVIDO COM SUCESSO", "SUCESSO", 1000);
            }
            catch
            {
                //esconde o botão
                bt_deletar2.Hide();
                //mensagem de erro
                MessageBox.Show("Preenchimento inválido, verifique os campos preenchidos.", "AVISO!", MessageBoxButtons.OK);
            }
        }

        private void bt_selecionar_Click(object sender, EventArgs e)
        {
            try 
            {
                //mostra o que será deletado e mostra o botão de deletar
                string comando = string.Format("SELECT e.cod_equipamento 'Equipamento', marcas_equip.descr_marca 'Marca', modelos_equip.descr_modelo 'Modelo', descricoes_equip.descricao 'Descrição', e.num_patrimonio 'Num Patrimonio', e.serialNum 'Código', e.cod_sap 'Cod Sap', locais.descr_local 'Local', status_equip.descr_status 'Status'\r\nFROM equipamentos e\r\nINNER JOIN marcas_equip ON marcas_equip.cod_marca = e.cod_marca\r\nINNER JOIN modelos_equip ON modelos_equip.cod_modelo = e.cod_modelo\r\nINNER JOIN descricoes_equip ON descricoes_equip.cod_descr = e.cod_descr\r\nINNER JOIN locais ON locais.cod_local = e.cod_local\r\nINNER JOIN status_equip ON status_equip.cod_status = e.cod_status WHERE e.serialNum LIKE '{0}';", txt_codigo3.Text);
                lv(lv_consulta, comando);
                bt_deletar2.Show();
            }
            catch
            {
                //mensagem de erro
                MessageBox.Show("Preenchimento inválido, verifique os campos preenchidos.", "AVISO!", MessageBoxButtons.OK);
            }
        }

        private void lv_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
