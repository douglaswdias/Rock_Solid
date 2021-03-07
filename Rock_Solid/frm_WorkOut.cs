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
			Abs abs = new Abs();
			Back back = new Back();

			#region Abs
			Abs.ABS_RETOABDOMEN = cb_RetoAbdomen.Text;
			Abs.ABS_INFRA = cb_Infra.Text;
			Abs.ABS_OBLIQUO = cb_Oblico.Text;
			Abs.ABS_PARALELAFIXA = cb_ParalelaFixa.Text;
			Abs.ABS_PRANCHAABDOMEN = cb_PranchaAbdomen.Text;

			Abs.ABS_RETOABDOMEN_SERIE = Convert.ToInt32(nSerie_RetoAbdomen.Value);
			Abs.ABS_INFRA_SERIE = Convert.ToInt32(nSerie_Infra.Value);
			Abs.ABS_OBLIQUO_SERIE = Convert.ToInt32(nSerie_Obliquo.Value);
			Abs.ABS_PARALELAFIXA_SERIE = Convert.ToInt32(nSerie_ParalelaFixa.Value);
			Abs.ABS_PRANCHAABDOMEN_SERIE = Convert.ToInt32(nSerie_PranchaAbdomen.Value);

			Abs.ABS_RETOABDOMEN_REP = Convert.ToInt32(nRep_RetoAbdomen.Value);
			Abs.ABS_INFRA_REP = Convert.ToInt32(nRep_Infra.Value);
			Abs.ABS_OBLIQUO_REP = Convert.ToInt32(nRep_Obliquo.Value);
			Abs.ABS_PARALELAFIXA_REP = Convert.ToInt32(nRep_ParalelaFixa.Value);
			Abs.ABS_PRANCHAABDOMEN_REP = Convert.ToInt32(nRep_PranchaAbdomen.Value);

			Abs.ABS_RETOABDOMEN_CARGA = Convert.ToInt32(nCarga_RetoAbdomen.Value);
			Abs.ABS_INFRA_CARGA = Convert.ToInt32(nCarga_Infra.Value);
			Abs.ABS_OBLIQUO_CARGA = Convert.ToInt32(nCarga_Obliquo.Value);
			Abs.ABS_PARALELAFIXA_CARGA = Convert.ToInt32(nCarga_ParalelaFixa.Value);
			Abs.ABS_PRANCHAABDOMEN_CARGA = Convert.ToInt32(nCarga_PranchaAbdomen.Value);

			Abs.ABS_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion
			#region Back
			Back.BACK_PULLEYCOSTAS = cb_PulleyCostas.Text;
			Back.BACK_PULLEYFRENTE = cb_PulleyFrente.Text;
			Back.BACK_PULLEYINVERTIDO = cb_PulleyInvertido.Text;
			Back.BACK_REMADAHORIZONTAL = cb_RemadaHorizontal.Text;
			Back.BACK_REMADAALTERNADA = cb_RemadaAlternada.Text;
			Back.BACK_REMADACAVALINHO = cb_RemadaCavalinho.Text;
			Back.BACK_PUXADORARTICULADO = cb_PuxadorArticulado.Text;
			Back.BACK_PECKDECK = cb_PeckDeckCostas.Text;
			Back.BACK_PULLOVER = cb_PullOverCostas.Text;
			Back.BACK_BARRAFIXA = cb_BarraFixa.Text;
			Back.BACK_VOADORINVERSO = cb_VoadorInverso.Text;

			Back.BACK_PULLEYCOSTAS_SERIE = Convert.ToInt32(nSerie_PulleyCostas.Value);
			Back.BACK_PULLEYFRENTE_SERIE = Convert.ToInt32(nSerie_PulleyFrente.Value);
			Back.BACK_PULLEYINVERTIDO_SERIE = Convert.ToInt32(nSerie_PulleyInvertido.Value);
			Back.BACK_REMADAHORIZONTAL_SERIE = Convert.ToInt32(nSerie_RemadaHorizontal.Value);
			Back.BACK_REMADAALTERNADA_SERIE = Convert.ToInt32(nSerie_RemadaAlternada.Value);
			Back.BACK_REMADACAVALINHO_SERIE = Convert.ToInt32(nSerie_RemadaCavalinho.Value);
			Back.BACK_PUXADORARTICULADO_SERIE = Convert.ToInt32(nSerie_PuxadorArticulado.Value);
			Back.BACK_PECKDECK_SERIE = Convert.ToInt32(nSerie_PeckDeckCostas.Value);
			Back.BACK_PULLOVER_SERIE = Convert.ToInt32(nSerie_PullOverCostas.Value);
			Back.BACK_BARRAFIXA_SERIE = Convert.ToInt32(nSerie_BarraFixa.Value);
			Back.BACK_VOADORINVERSO_SERIE = Convert.ToInt32(nSerie_VoadorInverso.Value);

			Back.BACK_PULLEYCOSTAS_REP = Convert.ToInt32(nRep_PulleyCostas.Value);
			Back.BACK_PULLEYFRENTE_REP = Convert.ToInt32(nRep_PulleyFrente.Value);
			Back.BACK_PULLEYINVERTIDO_REP = Convert.ToInt32(nRep_PulleyInvertido.Value);
			Back.BACK_REMADAHORIZONTAL_REP = Convert.ToInt32(nRep_RemadaHorizontal.Value);
			Back.BACK_REMADAALTERNADA_REP = Convert.ToInt32(nRep_RemadaAlternada.Value);
			Back.BACK_REMADACAVALINHO_REP = Convert.ToInt32(nRep_RemadaCavalinho.Value);
			Back.BACK_PUXADORARTICULADO_REP = Convert.ToInt32(nRep_PuxadorArticulado.Value);
			Back.BACK_PECKDECK_REP = Convert.ToInt32(nRep_PeckDeckCostas.Value);
			Back.BACK_PULLOVER_REP = Convert.ToInt32(nRep_PullOverCostas.Value);
			Back.BACK_BARRAFIXA_REP = Convert.ToInt32(nRep_BarraFixa.Value);
			Back.BACK_VOADORINVERSO_REP = Convert.ToInt32(nRep_VoadorInverso.Value);

			Back.BACK_PULLEYCOSTAS_CARGA = Convert.ToInt32(nCarga_PulleyCostas.Value);
			Back.BACK_PULLEYFRENTE_CARGA = Convert.ToInt32(nCarga_PulleyFrente.Value);
			Back.BACK_PULLEYINVERTIDO_CARGA = Convert.ToInt32(nCarga_PulleyInvertido.Value);
			Back.BACK_REMADAHORIZONTAL_CARGA = Convert.ToInt32(nCarga_RemadaHorizontal.Value);
			Back.BACK_REMADAALTERNADA_CARGA = Convert.ToInt32(nCarga_RemadaAlternada.Value);
			Back.BACK_REMADACAVALINHO_CARGA = Convert.ToInt32(nCarga_RemadaCavalinho.Value);
			Back.BACK_PUXADORARTICULADO_CARGA = Convert.ToInt32(nCarga_PuxadorArticulado.Value);
			Back.BACK_PECKDECK_CARGA = Convert.ToInt32(nCarga_PeckDeckCostas.Value);
			Back.BACK_PULLOVER_CARGA = Convert.ToInt32(nCarga_PullOverCostas.Value);
			Back.BACK_BARRAFIXA_CARGA = Convert.ToInt32(nCarga_BarraFixa.Value);
			Back.BACK_VOADORINVERSO_CARGA = Convert.ToInt32(nCarga_VoadorInverso.Value);

			Back.BACK_BACK = WorkOut.WORKOUT_ID;
			#endregion
			#region Biceps

			#endregion
			#region Chest

			#endregion
			#region Legs

			#endregion
			#region Shoulders

			#endregion
			#region Triceps

			#endregion
			#region WarmUp

			#endregion

			DataBase.NewWorkout(workout, abs, back);
		}
	}
}
