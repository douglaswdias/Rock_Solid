﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rock_Solid
{
	public partial class frm_Client : Form
	{
		string fileOrigin = "";
		string image = "";
		string fileDestiny = Global.profilePicturePath;
		string destiny = Global.profilePicturePath + "Default Profile.png";
		public frm_Client()
		{
			InitializeComponent();
			cb_State.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public  void ClearTB()
		{
			tb_ID.Clear();
			tb_Name.Clear();
			tb_PostCode.Clear();
			tb_Address.Clear();
			tb_Number.Clear();
			tb_Neighborhood.Clear();
			tb_City.Clear();
			cb_State.Text = "";
			tb_RG.Clear();
			tb_CPF.Clear();
			tb_Email.Clear();
			tb_Phone.Clear();
			clb_Phone.Text = "";
			tb_Cel.Clear();
			clb_Cel.Text = "";
			pb_User.ImageLocation = Global.profilePicturePath + "Default Profile.png";
			tb_Name.Focus();
		}

		public void ClearClient()
		{
			Client.CLIENT_ID = 0;
			Client.CLIENT_NAME = "";
			Client.CLIENT_POSTCODE = "";
			Client.CLIENT_ADDRESS = "";
			Client.CLIENT_NUMBER = "";
			Client.CLIENT_NEIGHBORHOOD = "";
			Client.CLIENT_CITY = "";
			Client.CLIENT_STATE = "";
			Client.CLIENT_RG = "";
			Client.CLIENT_CPF = "";
			Client.CLIENT_EMAIL = "";
			Client.CLIENT_PHONE = "";
			Client.CLIENT_CEL = "";
			Client.CLIENT_PROFILEIMGPATH = Global.profilePicturePath + "Default Profile.png";
		}

		private void rb_PhysicalPerson_Click(object sender, EventArgs e)
		{
			tb_CPF.Clear();
			tb_RG.Clear();
			tb_CPF.Size = new Size(88, 20);
			lb_CPF.Text = "CFP";
			tb_CPF.Mask = "000.000.000-00";
			tb_RG.Size = new Size(73, 20);
			lb_RG.Text = "RG";
			tb_RG.Mask = "00.000.000-0";
		}

		private void rb_LegalPerson_Click(object sender, EventArgs e)
		{
			tb_CPF.Clear();
			tb_RG.Clear();
			tb_CPF.Size = new Size(107, 20);
			lb_CPF.Text = "CNPJ";
			tb_CPF.Mask = "00.000.000/0000-00";
			tb_RG.Size = new Size(88, 20);
			lb_RG.Text = "IE";
			tb_RG.Mask = "000.000.000.000";
		}

		private void btn_New_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Criar Novo Cliente?", "NOVO", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				ClearTB();
				ClearClient();
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			if(destiny == "")
			{
				if(MessageBox.Show("Nenhuma Imagem Selecionada, Deseja Continuar?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
			}
			if(destiny != "")
			{
				System.IO.File.Copy(fileOrigin, destiny, true);
				if (File.Exists(destiny))
				{
					pb_User.ImageLocation = destiny;
				}
				else
				{
					if (MessageBox.Show("Erro ao Localizar Imagem, Deseja Continuar?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						return;
					}
				}
			}
			pb_User.ImageLocation = destiny;
			Client client = new Client();
			Client.CLIENT_NAME = tb_Name.Text;
			Client.CLIENT_POSTCODE = tb_PostCode.Text;
			Client.CLIENT_ADDRESS = tb_Address.Text;
			Client.CLIENT_NUMBER = tb_Number.Text;
			Client.CLIENT_NEIGHBORHOOD = tb_Neighborhood.Text;
			Client.CLIENT_CITY = tb_City.Text;
			Client.CLIENT_STATE = cb_State.Text;
			Client.CLIENT_RG = tb_RG.Text;
			Client.CLIENT_CPF =tb_CPF.Text;
			Client.CLIENT_EMAIL = tb_Email.Text;
			Client.CLIENT_PHONE = tb_Phone.Text;
			Client.CLIENT_CEL =tb_Cel.Text;
			Client.CLIENT_PROFILEIMGPATH = destiny;
			DataBase.NewClient(client);
			tb_Name.Focus();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (Client.CLIENT_ID != 0)
			{
				DialogResult res = MessageBox.Show("Confirma Exclusão de Cliente?", "EXCLUIR", MessageBoxButtons.YesNo);
				if (res == DialogResult.Yes)
				{
					try
					{
						DataTable dt = new DataTable();
						dt = DataBase.DeleteClient(tb_ID.Text);
						MessageBox.Show("Cliente Excluído com Sucesso");
						tb_Name.Focus();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Erro ao Excluir Cliente");
						tb_Name.Focus();
						throw ex;
					}
				}
			}
			else
			{
				MessageBox.Show("Nenhum Cliente Selecionado");
			}
			ClearTB();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			frm_ClientList client = new frm_ClientList();
			client.ShowDialog();
			tb_ID.Focus();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			ClearTB();
			ClearClient();
			Close();
		}

		private void btn_ProfilePicture_Click(object sender, EventArgs e)
		{
			fileOrigin = "";
			image = "";
			fileDestiny = Global.profilePicturePath;
			destiny = Global.profilePicturePath + "Default Profile.png";

			if (ofd_Client.ShowDialog() == DialogResult.OK)
			{
				fileOrigin = ofd_Client.FileName;
				image = tb_CPF.Text + ofd_Client.SafeFileName;
				destiny = fileDestiny + image;
			}
			if (File.Exists(destiny))
			{
				if (MessageBox.Show("Deseja Subistituir o Arquivo Existente? ", "SUBSTITUIR", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
			}
			pb_User.ImageLocation = fileOrigin;
		}

		private void tb_ID_Enter(object sender, EventArgs e)
		{
			tb_ID.Text = Client.CLIENT_ID.ToString();
			tb_Name.Text = Client.CLIENT_NAME;
			tb_PostCode.Text = Client.CLIENT_POSTCODE;
			tb_Address.Text = Client.CLIENT_ADDRESS;
			tb_Number.Text = Client.CLIENT_NUMBER;
			tb_Neighborhood.Text = Client.CLIENT_NEIGHBORHOOD;
			tb_City.Text = Client.CLIENT_CITY;
			cb_State.Text = Client.CLIENT_STATE;
			tb_RG.Text = Client.CLIENT_RG;
			tb_CPF.Text = Client.CLIENT_CPF;
			tb_Email.Text = Client.CLIENT_EMAIL;
			tb_Phone.Text = Client.CLIENT_PHONE;
			tb_Cel.Text = Client.CLIENT_CEL;
			pb_User.ImageLocation = Client.CLIENT_PROFILEIMGPATH;
		}

		private void tb_ID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					DataTable dt = new DataTable();
					dt = DataBase.ClientList(tb_ID.Text);
					tb_Name.Text = dt.Rows[0].Field<string>("CLIENT_NAME").ToString();
					tb_PostCode.Text = dt.Rows[0].Field<string>("CLIENT_POSTCODE").ToString();
					tb_Address.Text = dt.Rows[0].Field<string>("CLIENT_ADDRESS").ToString();
					tb_Number.Text = dt.Rows[0].Field<string>("CLIENT_NUMBER").ToString();
					tb_Neighborhood.Text = dt.Rows[0].Field<string>("CLIENT_NEIGHBORHOOD").ToString();
					tb_City.Text = dt.Rows[0].Field<string>("CLIENT_CITY").ToString();
					cb_State.Text = dt.Rows[0].Field<string>("CLIENT_STATE").ToString();
					tb_RG.Text = dt.Rows[0].Field<string>("CLIENT_RG").ToString();
					tb_CPF.Text = dt.Rows[0].Field<string>("CLIENT_CPF").ToString();
					tb_Email.Text = dt.Rows[0].Field<string>("CLIENT_EMAIL").ToString();
					tb_Phone.Text = dt.Rows[0].Field<string>("CLIENT_PHONE").ToString();
					tb_Cel.Text = dt.Rows[0].Field<string>("CLIENT_CEL").ToString();
					pb_User.ImageLocation = dt.Rows[0].Field<string>("CLIENT_PROFILEIMGPATH").ToString();
					Client.CLIENT_ID = Convert.ToInt32(tb_ID.Text);
					Client.CLIENT_NAME = tb_Name.Text;
					Client.CLIENT_POSTCODE = tb_PostCode.Text;
					Client.CLIENT_ADDRESS = tb_Address.Text;
					Client.CLIENT_NUMBER = tb_Number.Text;
					Client.CLIENT_NEIGHBORHOOD = tb_Neighborhood.Text;
					Client.CLIENT_CITY = tb_City.Text;
					Client.CLIENT_STATE = cb_State.Text;
					Client.CLIENT_RG = tb_RG.Text;
					Client.CLIENT_CPF = tb_CPF.Text;
					Client.CLIENT_EMAIL = tb_Email.Text;
					Client.CLIENT_PHONE = tb_Phone.Text;
					Client.CLIENT_CEL = tb_Cel.Text;
					Client.CLIENT_PROFILEIMGPATH = pb_User.ImageLocation;
					tb_Name.Focus();
				}
				catch (Exception ex)
				{
					if (Client.CLIENT_ID != 0)
					{
						MessageBox.Show("Usuário não Cadastrado");
						ClearTB();
						ClearClient();
						tb_Name.Focus();
						//throw ex;
					}
				}
			}
		}

		private void frm_Client_Load(object sender, EventArgs e)
		{
			tb_ID.Focus();
		}

		private void frm_Client_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) //Pode ser usado tambem (e.KeyCode == Keys.Enter)
			{
				this.ProcessTabKey(true);
				e.Handled = true; //Retira o som do windos na tecla
			}
		}
	}
}
