using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Solid
{
	public partial class frm_WorkOut : Form
	{
		public frm_WorkOut()
		{
			InitializeComponent();
			DropDownLists();
		}

		private void DropDownLists()
		{
			#region Bíceps
			cb_RoscaDireta.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaAlternada.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaMartelo.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaConcentrada.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaArticulada.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaBilateral.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaRoldana.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaSimultanea.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Tríceps
			cb_Pulley.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaTesta.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PulleyCorda.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaFrancesa.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RoscaSupinada.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Coice.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Invertido.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Mergulho.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Ombros
			cb_ElevacaoLateral.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_ElevacaoFrontal.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_ElevacaoOmbro.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_DesenvolvimentoCostas.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_DesenvolvimentoFrente.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_DesenvolvimentoDumbell.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RemadaAlta.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Pernas
			cb_CadeiraExtensora.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_CadeiraFlexora.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Adutor.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Abdutor.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_LegPress.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Agachamento.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Hack.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Panturrilha.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Stiff.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Gluteo.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Avanco.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Peito
			cb_SupinoReto.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_SupinoInclinado.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_SupinoSentado.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_SupinoDumbell.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Peck.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PeckDeckPeito.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_crucifixo.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_CrossOver.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Costas
			cb_PulleyCostas.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PulleyFrente.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PulleyInvertido.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RemadaHorizontal.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RemadaAlternada.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_RemadaCavalinho.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PuxadorArticulado.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PeckDeckCostas.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PullOverCostas.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_BarraFixa.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_VoadorInverso.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Abdomen
			cb_RetoAbdomen.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Infra.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Oblico.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_ParalelaFixa.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_PranchaAbdomen.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
			#region Aquecimento
			cb_Esteira.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Bicicleta.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Eliptico.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Corda.DropDownStyle = ComboBoxStyle.DropDownList;
			#endregion
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Print_Click(object sender, EventArgs e)
		{
			frm_Print print = new frm_Print();
			print.ShowDialog();
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			WorkOut workout = new WorkOut();
			WorkOut.WORKOUT_BICEPS = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_TRICEPS = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_SHOULDERS = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_LEGS= WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_CHEST = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_BACK = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_ABS = WorkOut.WORKOUT_ID;
			WorkOut.WORKOUT_WARMUP = WorkOut.WORKOUT_ID;
			DataBase.NewWorkout(workout);
		}
	}
}
