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
			cb_Crucifixo.DropDownStyle = ComboBoxStyle.DropDownList;
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
			Biceps biceps = new Biceps();
			Chest chest = new Chest();
			Legs legs = new Legs();
			Shoulders shoulders = new Shoulders();
			Triceps triceps = new Triceps();
			WarmUp warmup = new WarmUp();

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

			Back.BACK_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion
			#region Biceps
			Biceps.BICEPS_ROSCADIRETA = cb_RoscaDireta.Text;
			Biceps.BICEPS_ROSCAALTERNADA = cb_RoscaAlternada.Text;
			Biceps.BICEPS_ROSCAMARTELO = cb_RoscaMartelo.Text;
			Biceps.BICEPS_ROSCACONCENTRADA = cb_RoscaConcentrada.Text;
			Biceps.BICEPS_ROSCAARTICULADA = cb_RoscaArticulada.Text;
			Biceps.BICEPS_ROSCABILATERAL = cb_RoscaBilateral.Text;
			Biceps.BICEPS_ROSCAROLDANA = cb_RoscaRoldana.Text;
			Biceps.BICEPS_ROSCASIMULTANEA = cb_RoscaSimultanea.Text;

			Biceps.BICEPS_ROSCADIRETA_SERIE = Convert.ToInt32(nSerie_RoscaDireta.Value);
			Biceps.BICEPS_ROSCAALTERNADA_SERIE = Convert.ToInt32(nSerie_RoscaAlternada.Value);
			Biceps.BICEPS_ROSCAMARTELO_SERIE = Convert.ToInt32(nSerie_RoscaMartelo.Value);
			Biceps.BICEPS_ROSCACONCENTRADA_SERIE = Convert.ToInt32(nSerie_RoscaConcentrada.Value);
			Biceps.BICEPS_ROSCAARTICULADA_SERIE = Convert.ToInt32(nSerie_RoscaArticulada.Value);
			Biceps.BICEPS_ROSCABILATERAL_SERIE = Convert.ToInt32(nSerie_RoscaBilateral.Value);
			Biceps.BICEPS_ROSCAROLDANA_SERIE = Convert.ToInt32(nSerie_RoscaRoldana.Value);
			Biceps.BICEPS_ROSCASIMULTANEA_SERIE = Convert.ToInt32(nSerie_RoscaSimultanea.Value);

			Biceps.BICEPS_ROSCADIRETA_REP = Convert.ToInt32(nRep_RoscaDireta.Value);
			Biceps.BICEPS_ROSCAALTERNADA_REP = Convert.ToInt32(nRep_RoscaAlternada.Value);
			Biceps.BICEPS_ROSCAMARTELO_REP = Convert.ToInt32(nRep_RoscaMartelo.Value);
			Biceps.BICEPS_ROSCACONCENTRADA_REP = Convert.ToInt32(nRep_RoscaConcentrada.Value);
			Biceps.BICEPS_ROSCAARTICULADA_REP = Convert.ToInt32(nRep_RoscaArticulada.Value);
			Biceps.BICEPS_ROSCABILATERAL_REP = Convert.ToInt32(nRep_RoscaBilateral.Value);
			Biceps.BICEPS_ROSCAROLDANA_REP = Convert.ToInt32(nRep_RoscaRoldana.Value);
			Biceps.BICEPS_ROSCASIMULTANEA_REP = Convert.ToInt32(nRep_RoscaSimultanea.Value);

			Biceps.BICEPS_ROSCADIRETA_CARGA = Convert.ToInt32(nCarga_RoscaDireta.Value);
			Biceps.BICEPS_ROSCAALTERNADA_CARGA = Convert.ToInt32(nCarga_RoscaAlternada.Value);
			Biceps.BICEPS_ROSCAMARTELO_CARGA = Convert.ToInt32(nCarga_RoscaMartelo.Value);
			Biceps.BICEPS_ROSCACONCENTRADA_CARGA = Convert.ToInt32(nCarga_RoscaConcentrada.Value);
			Biceps.BICEPS_ROSCAARTICULADA_CARGA = Convert.ToInt32(nCarga_RoscaBilateral.Value);
			Biceps.BICEPS_ROSCABILATERAL_CARGA = Convert.ToInt32(nCarga_RoscaRoldana.Value);
			Biceps.BICEPS_ROSCAROLDANA_CARGA = Convert.ToInt32(nCarga_RoscaRoldana.Value);
			Biceps.BICEPS_ROSCASIMULTANEA_CARGA = Convert.ToInt32(nCarga_RoscaSimultanea.Value);

			Biceps.BICEPS_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion
			#region Chest
			Chest.CHEST_SUPINORETO = cb_SupinoReto.Text;
			Chest.CHEST_SUPINOINCLINADO = cb_SupinoInclinado.Text;
			Chest.CHEST_SUPINOSENTADO = cb_SupinoSentado.Text;
			Chest.CHEST_SUPINODUMBELL = cb_SupinoDumbell.Text;
			Chest.CHEST_PECK = cb_Peck.Text;
			Chest.CHEST_PECKDECK = cb_PeckDeckPeito.Text;
			Chest.CHEST_CRUCIFIXO = cb_Crucifixo.Text;
			Chest.CHEST_CROSSOVER = cb_CrossOver.Text;

			Chest.CHEST_SUPINORETO_SERIE = Convert.ToInt32(nSerie_SupinoReto.Value);
			Chest.CHEST_SUPINOINCLINADO_SERIE = Convert.ToInt32(nSerie_SupinoInclinado.Value);
			Chest.CHEST_SUPINOSENTADO_SERIE = Convert.ToInt32(nSerie_SupinoSentado.Value);
			Chest.CHEST_SUPINODUMBELL_SERIE = Convert.ToInt32(nSerie_SupinoDumbell.Value);
			Chest.CHEST_PECK_SERIE = Convert.ToInt32(nSerie_Peck.Value);
			Chest.CHEST_PECKDECK_SERIE = Convert.ToInt32(nSerie_PeckDeckPeito.Value);
			Chest.CHEST_CRUCIFIXO_SERIE = Convert.ToInt32(nSerie_Crucifixo.Value);
			Chest.CHEST_CROSSOVER_SERIE = Convert.ToInt32(nSerie_CrossOver.Value);

			Chest.CHEST_SUPINORETO_REP = Convert.ToInt32(nRep_SupinoReto.Value);
			Chest.CHEST_SUPINOINCLINADO_REP = Convert.ToInt32(nRep_SupinoInclinado.Value);
			Chest.CHEST_SUPINOSENTADO_REP = Convert.ToInt32(nRep_SupinoSentado.Value);
			Chest.CHEST_SUPINODUMBELL_REP = Convert.ToInt32(nRep_SupinoDumbell.Value);
			Chest.CHEST_PECK_REP = Convert.ToInt32(nRep_Peck.Value);
			Chest.CHEST_PECKDECK_REP = Convert.ToInt32(nRep_PeckDeckPeito.Value);
			Chest.CHEST_CRUCIFIXO_REP = Convert.ToInt32(nRep_Crucifixo.Value);
			Chest.CHEST_CROSSOVER_REP = Convert.ToInt32(nRep_CrossOver.Value);

			Chest.CHEST_SUPINORETO_CARGA = Convert.ToInt32(nCarga_SupinoReto.Value);
			Chest.CHEST_SUPINOINCLINADO_CARGA = Convert.ToInt32(nCarga_SupinoInclinado.Value);
			Chest.CHEST_SUPINOSENTADO_CARGA = Convert.ToInt32(nCarga_SupinoSentado.Value);
			Chest.CHEST_SUPINODUMBELL_CARGA = Convert.ToInt32(nCarga_SupinoDumbell.Value);
			Chest.CHEST_PECK_CARGA = Convert.ToInt32(nCarga_Peck.Value);
			Chest.CHEST_PECKDECK_CARGA = Convert.ToInt32(nCarga_PeckDeckPeito.Value);
			Chest.CHEST_CRUCIFIXO_CARGA = Convert.ToInt32(nCarga_Crucifixo.Value);
			Chest.CHEST_CROSSOVER_CARGA = Convert.ToInt32(nCarga_CrossOver.Value);
			#endregion
			#region Legs
			Legs.LEGS_CADEIRAEXTENSORA = cb_CadeiraExtensora.Text;
			Legs.LEGS_CADEIRAFLEXORA = cb_CadeiraFlexora.Text;
			Legs.LEGS_ADUTOR = cb_Adutor.Text;
			Legs.LEGS_ABDUTOR = cb_Abdutor.Text;
			Legs.LEGS_LEGPRESS = cb_LegPress.Text;
			Legs.LEGS_AGACHAMENTOLIVRE = cb_Agachamento.Text;
			Legs.LEGS_HACK = cb_Hack.Text;
			Legs.LEGS_PANTURRILHA = cb_Panturrilha.Text;
			Legs.LEGS_STIFF = cb_Stiff.Text;
			Legs.LEGS_GLUTEO = cb_Gluteo.Text;
			Legs.LEGS_AVANCO = cb_Avanco.Text;

			Legs.LEGS_CADEIRAEXTENSORA_SERIE = Convert.ToInt32(nSerie_CadeiraExtensorar.Value);
			Legs.LEGS_CADEIRAFLEXORA_SERIE = Convert.ToInt32(nSerie_CadeiraFlexora.Value);
			Legs.LEGS_ADUTOR_SERIE = Convert.ToInt32(nSerie_Adutor.Value);
			Legs.LEGS_ABDUTOR_SERIE = Convert.ToInt32(nSerie_Abdutor.Value);
			Legs.LEGS_LEGPRESS_SERIE = Convert.ToInt32(nSerie_LegPress.Value);
			Legs.LEGS_AGACHAMENTOLIVRE_SERIE = Convert.ToInt32(nSerie_Agachamento.Value);
			Legs.LEGS_HACK_SERIE = Convert.ToInt32(nSerie_Hack.Value);
			Legs.LEGS_PANTURRILHA_SERIE = Convert.ToInt32(nSerie_Panturrilha.Value);
			Legs.LEGS_STIFF_SERIE = Convert.ToInt32(nSerie_Stiff.Value);
			Legs.LEGS_GLUTEO_SERIE = Convert.ToInt32(nSerie_Gluteo.Value);
			Legs.LEGS_AVANCO_SERIE = Convert.ToInt32(nSerie_Avanco.Value);

			Legs.LEGS_CADEIRAEXTENSORA_REP = Convert.ToInt32(nRep_CadeiraExtensora.Value);
			Legs.LEGS_CADEIRAFLEXORA_REP = Convert.ToInt32(nRep_CadeiraFlexora.Value);
			Legs.LEGS_ADUTOR_REP = Convert.ToInt32(nRep_Adutor.Value);
			Legs.LEGS_ABDUTOR_REP = Convert.ToInt32(nRep_Abdutor.Value);
			Legs.LEGS_LEGPRESS_REP = Convert.ToInt32(nRep_LegPress.Value);
			Legs.LEGS_AGACHAMENTOLIVRE_REP = Convert.ToInt32(nRep_Agachamento.Value);
			Legs.LEGS_HACK_REP = Convert.ToInt32(nRep_Hack.Value);
			Legs.LEGS_PANTURRILHA_REP = Convert.ToInt32(nRep_Panturrilha.Value);
			Legs.LEGS_STIFF_REP = Convert.ToInt32(nRep_Stiff.Value);
			Legs.LEGS_GLUTEO_REP = Convert.ToInt32(nRep_Gluteo.Value);
			Legs.LEGS_AVANCO_REP = Convert.ToInt32(nRep_Avanco.Value);

			Legs.LEGS_CADEIRAEXTENSORA_CARGA = Convert.ToInt32(nCarga_CadeiraExtensora.Value);
			Legs.LEGS_CADEIRAFLEXORA_CARGA = Convert.ToInt32(nCarga_CadeiraFlexora.Value);
			Legs.LEGS_ADUTOR_CARGA = Convert.ToInt32(nCarga_Adutor.Value);
			Legs.LEGS_ABDUTOR_CARGA = Convert.ToInt32(nCarga_Abdutor.Value);
			Legs.LEGS_LEGPRESS_CARGA = Convert.ToInt32(nCarga_LegPress.Value);
			Legs.LEGS_AGACHAMENTOLIVRE_CARGA = Convert.ToInt32(nCarga_Agachamento.Value);
			Legs.LEGS_HACK_CARGA = Convert.ToInt32(nCarga_Hack.Value);
			Legs.LEGS_PANTURRILHA_CARGA = Convert.ToInt32(nCarga_Panturrilha.Value);
			Legs.LEGS_STIFF_CARGA = Convert.ToInt32(nCarga_Stiff.Value);
			Legs.LEGS_GLUTEO_CARGA = Convert.ToInt32(nCarga_Gluteo.Value);
			Legs.LEGS_AVANCO_CARGA = Convert.ToInt32(nCarga_Avanco.Value);
			#endregion
			#region Shoulders
			Shoulders.SHOULDERS_ELEVACAOLATERAL = cb_ElevacaoLateral.Text;
			Shoulders.SHOULDERS_ELEVACAOFRONTAL = cb_ElevacaoFrontal.Text;
			Shoulders.SHOULDERS_ELEVACAOOMBRO = cb_ElevacaoOmbro.Text;
			Shoulders.SHOULDERS_DEVCOSTAS = cb_DesenvolvimentoCostas.Text;
			Shoulders.SHOULDERS_DEVFRENTE = cb_DesenvolvimentoFrente.Text;
			Shoulders.SHOULDERS_DEVDUMBELL = cb_DesenvolvimentoDumbell.Text;
			Shoulders.SHOULDERS_REMADAALTA = cb_RemadaAlta.Text;

			Shoulders.SHOULDERS_ELEVACAOLATERAL_SERIE = Convert.ToInt32(nSerie_ElevacaoLateral.Value);
			Shoulders.SHOULDERS_ELEVACAOFRONTAL_SERIE = Convert.ToInt32(nSerie_ElevacaoFrontal.Value);
			Shoulders.SHOULDERS_ELEVACAOOMBRO_SERIE = Convert.ToInt32(nSerie_ElevacaoOmbro.Value);
			Shoulders.SHOULDERS_DEVCOSTAS_SERIE = Convert.ToInt32(nSerie_DesenvolvimentoCostas.Value);
			Shoulders.SHOULDERS_DEVFRENTE_SERIE = Convert.ToInt32(nSerie_DesenvolvimentoFrente.Value);
			Shoulders.SHOULDERS_DEVDUMBELL_SERIE = Convert.ToInt32(nSerie_DesenvolvimentoDumbell.Value);
			Shoulders.SHOULDERS_REMADAALTA_SERIE = Convert.ToInt32(nSerie_RemadaAlta.Value);

			Shoulders.SHOULDERS_ELEVACAOLATERAL_REP = Convert.ToInt32(nRep_ElevacaoLateral.Value);
			Shoulders.SHOULDERS_ELEVACAOFRONTAL_REP = Convert.ToInt32(nRep_ElevacaoFrontal.Value);
			Shoulders.SHOULDERS_ELEVACAOOMBRO_REP = Convert.ToInt32(nRep_ElevacaoOmbro.Value);
			Shoulders.SHOULDERS_DEVCOSTAS_REP = Convert.ToInt32(nRep_DesenvolvimentoCostas.Value);
			Shoulders.SHOULDERS_DEVFRENTE_REP = Convert.ToInt32(nRep_DesenvolvimentoFrente.Value);
			Shoulders.SHOULDERS_DEVDUMBELL_REP = Convert.ToInt32(nRep_DesenvolvimentoDumbell.Value);
			Shoulders.SHOULDERS_REMADAALTA_REP = Convert.ToInt32(nRep_RemadaAlta.Value);

			Shoulders.SHOULDERS_ELEVACAOLATERAL_CARGA = Convert.ToInt32(nCarga_ElevacaoLateral.Value);
			Shoulders.SHOULDERS_ELEVACAOFRONTAL_CARGA = Convert.ToInt32(nCarga_ElevacaoFrontal.Value);
			Shoulders.SHOULDERS_ELEVACAOOMBRO_CARGA = Convert.ToInt32(nCarga_ElevacaoOmbro.Value);
			Shoulders.SHOULDERS_DEVCOSTAS_CARGA = Convert.ToInt32(nCarga_DesenvolvimentoCostas.Value);
			Shoulders.SHOULDERS_DEVFRENTE_CARGA = Convert.ToInt32(nCarga_DesenvolvimentoFrente.Value);
			Shoulders.SHOULDERS_DEVDUMBELL_CARGA = Convert.ToInt32(nCarga_DesenvolvimentoDumbell.Value);
			Shoulders.SHOULDERS_REMADAALTA_CARGA = Convert.ToInt32(nCarga_RemadaAlta.Value);

			Shoulders.SHOULDERS_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion
			#region Triceps
			Triceps.TRICEPS_PULLEY = cb_Pulley.Text;
			Triceps.TRICEPS_ROSCATESTA = cb_RoscaTesta.Text;
			Triceps.TRICEPS_PULLEYCORDA = cb_PulleyCorda.Text;
			Triceps.TRICEPS_ROSCAFRANCESA = cb_RoscaFrancesa.Text;
			Triceps.TRICEPS_ROSCASUPINADA = cb_RoscaSupinada.Text;
			Triceps.TRICEPS_COICE = cb_Coice.Text;
			Triceps.TRICEPS_INVERTIDO = cb_Invertido.Text;
			Triceps.TRICEPS_MERGULHO = cb_Mergulho.Text;

			Triceps.TRICEPS_PULLEY_SERIE = Convert.ToInt32(nSerie_Pulley.Value);
			Triceps.TRICEPS_ROSCATESTA_SERIE = Convert.ToInt32(nSerie_RoscaTesta.Value);
			Triceps.TRICEPS_PULLEYCORDA_SERIE = Convert.ToInt32(nSerie_PulleyCorda.Value);
			Triceps.TRICEPS_ROSCAFRANCESA_SERIE = Convert.ToInt32(nSerie_RoscaFrancesa.Value);
			Triceps.TRICEPS_ROSCASUPINADA_SERIE = Convert.ToInt32(nSerie_RoscaSupinada.Value);
			Triceps.TRICEPS_COICE_SERIE = Convert.ToInt32(nSerie_Coice.Value);
			Triceps.TRICEPS_INVERTIDO_SERIE = Convert.ToInt32(nSerie_Invertido.Value);
			Triceps.TRICEPS_MERGULHO_SERIE = Convert.ToInt32(nSerie_Mergulho.Value);

			Triceps.TRICEPS_PULLEY_REP = Convert.ToInt32(nRep_Pulley.Value);
			Triceps.TRICEPS_ROSCATESTA_REP = Convert.ToInt32(nRep_RoscaTesta.Value);
			Triceps.TRICEPS_PULLEYCORDA_REP = Convert.ToInt32(nRep_PulleyCorda.Value);
			Triceps.TRICEPS_ROSCAFRANCESA_REP = Convert.ToInt32(nRep_RoscaFrancesa.Value);
			Triceps.TRICEPS_ROSCASUPINADA_REP = Convert.ToInt32(nRep_RoscaSupinada.Value);
			Triceps.TRICEPS_COICE_REP = Convert.ToInt32(nRep_Coice.Value);
			Triceps.TRICEPS_INVERTIDO_REP = Convert.ToInt32(nRep_Invertido.Value);
			Triceps.TRICEPS_MERGULHO_REP = Convert.ToInt32(nRep_Mergulho.Value);

			Triceps.TRICEPS_PULLEY_CARGA = Convert.ToInt32(nCarga_Pulley.Value);
			Triceps.TRICEPS_ROSCATESTA_CARGA = Convert.ToInt32(nCarga_RoscaTesta.Value);
			Triceps.TRICEPS_PULLEYCORDA_CARGA = Convert.ToInt32(nCarga_PulleyCorda.Value);
			Triceps.TRICEPS_ROSCAFRANCESA_CARGA = Convert.ToInt32(nCarga_RoscaFrancesa.Value);
			Triceps.TRICEPS_ROSCASUPINADA_CARGA = Convert.ToInt32(nCarga_RoscaSupinada.Value);
			Triceps.TRICEPS_COICE_CARGA = Convert.ToInt32(nCarga_Coice.Value);
			Triceps.TRICEPS_INVERTIDO_CARGA = Convert.ToInt32(nCarga_Invertido.Value);
			Triceps.TRICEPS_MERGULHO_CARGA = Convert.ToInt32(nCarga_Mergulho.Value);

			Triceps.TRICEPS_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion
			#region WarmUp
			WarmUp.WARMUP_ESTEIRA = cb_Esteira.Text;
			WarmUp.WARMUP_BICICLETA = cb_Bicicleta.Text;
			WarmUp.WARMUP_ELIPTICO = cb_Eliptico.Text;
			WarmUp.WARMUP_CORDA = cb_Corda.Text;

			WarmUp.WARMUP_ESTEIRA_SERIE = Convert.ToInt32(nSerie_Esteira.Value);
			WarmUp.WARMUP_BICICLETA_SERIE = Convert.ToInt32(nSerie_Bicicleta.Value);
			WarmUp.WARMUP_ELIPTICO_SERIE = Convert.ToInt32(nSerie_Eliptico.Value);
			WarmUp.WARMUP_CORDA_SERIE = Convert.ToInt32(nSerie_Corda.Value);

			WarmUp.WARMUP_ESTEIRA_REP = Convert.ToInt32(nRep_Esteira.Value);
			WarmUp.WARMUP_BICICLETA_REP = Convert.ToInt32(nRep_Bicicleta.Value);
			WarmUp.WARMUP_ELIPTICO_REP = Convert.ToInt32(nRep_Eliptico.Value);
			WarmUp.WARMUP_CORDA_REP = Convert.ToInt32(nRep_Corda.Value);

			WarmUp.WARMUP_ESTEIRA_CARGA = Convert.ToInt32(nCarga_Esteira.Value);
			WarmUp.WARMUP_BICICLETA_CARGA = Convert.ToInt32(nCarga_Bicicleta.Value);
			WarmUp.WARMUP_ELIPTICO_CARGA = Convert.ToInt32(nCarga_Eliptico.Value);
			WarmUp.WARMUP_CORDA_CARGA = Convert.ToInt32(nCarga_Corda.Value);

			WarmUp.WARMUP_WORKOUT = WorkOut.WORKOUT_ID;
			#endregion

			DataBase.NewWorkout(workout, abs, back, biceps, chest, legs, shoulders, triceps, warmup);
		}

		private void frm_WorkOut_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) //Pode ser usado tambem (e.KeyCode == Keys.Enter)
			{
				this.ProcessTabKey(true);
				e.Handled = true; //Retira o som do windos na tecla
			}
		}

		private void frm_WorkOut_Load(object sender, EventArgs e)
		{
			#region Abs
			cb_RetoAbdomen.Text = Abs.ABS_RETOABDOMEN;
			cb_Infra.Text = Abs.ABS_INFRA;
			cb_Oblico.Text = Abs.ABS_OBLIQUO;
			cb_ParalelaFixa.Text = Abs.ABS_PARALELAFIXA;
			cb_PranchaAbdomen.Text = Abs.ABS_PRANCHAABDOMEN;

			nSerie_RetoAbdomen.Value = Abs.ABS_RETOABDOMEN_SERIE;
			nSerie_Infra.Value = Abs.ABS_INFRA_SERIE;
			nSerie_Obliquo.Value = Abs.ABS_OBLIQUO_SERIE;
			nSerie_ParalelaFixa.Value = Abs.ABS_PARALELAFIXA_SERIE;
			nSerie_PranchaAbdomen.Value = Abs.ABS_PRANCHAABDOMEN_SERIE;

			nRep_RetoAbdomen.Value = Abs.ABS_RETOABDOMEN_REP;
			nRep_Infra.Value = Abs.ABS_INFRA_REP;
			nRep_Obliquo.Value = Abs.ABS_OBLIQUO_REP;
			nRep_ParalelaFixa.Value = Abs.ABS_PARALELAFIXA_REP;
			nRep_PranchaAbdomen.Value = Abs.ABS_PRANCHAABDOMEN_REP;

			nCarga_RetoAbdomen.Value = Abs.ABS_RETOABDOMEN_CARGA;
			nCarga_Infra.Value = Abs.ABS_INFRA_CARGA;
			nCarga_Obliquo.Value = Abs.ABS_OBLIQUO_CARGA;
			nCarga_ParalelaFixa.Value = Abs.ABS_PARALELAFIXA_CARGA;
			nCarga_PranchaAbdomen.Value = Abs.ABS_PRANCHAABDOMEN_CARGA;
			#endregion
			#region Back
			cb_PulleyCostas.Text = Back.BACK_PULLEYCOSTAS;
			cb_PulleyFrente.Text = Back.BACK_PULLEYFRENTE;
			cb_PulleyInvertido.Text = Back.BACK_PULLEYINVERTIDO;
			cb_RemadaHorizontal.Text = Back.BACK_REMADAHORIZONTAL;
			cb_RemadaAlternada.Text = Back.BACK_REMADAALTERNADA;
			cb_RemadaCavalinho.Text = Back.BACK_REMADACAVALINHO;
			cb_PuxadorArticulado.Text = Back.BACK_PUXADORARTICULADO;
			cb_PeckDeckCostas.Text = Back.BACK_PECKDECK;
			cb_PullOverCostas.Text = Back.BACK_PULLOVER;
			cb_BarraFixa.Text = Back.BACK_BARRAFIXA;
			cb_VoadorInverso.Text = Back.BACK_VOADORINVERSO;

			nSerie_PulleyCostas.Value = Back.BACK_PULLEYCOSTAS_SERIE;
			nSerie_PulleyFrente.Value = Back.BACK_PULLEYFRENTE_SERIE;
			nSerie_PulleyInvertido.Value = Back.BACK_PULLEYINVERTIDO_SERIE;
			nSerie_RemadaHorizontal.Value = Back.BACK_REMADAHORIZONTAL_SERIE;
			nSerie_RemadaAlternada.Value = Back.BACK_REMADAALTERNADA_SERIE;
			nSerie_RemadaCavalinho.Value = Back.BACK_REMADACAVALINHO_SERIE;
			nSerie_PuxadorArticulado.Value = Back.BACK_PUXADORARTICULADO_SERIE;
			nSerie_PeckDeckCostas.Value = Back.BACK_PECKDECK_SERIE;
			nSerie_PullOverCostas.Value = Back.BACK_PULLOVER_SERIE;
			nSerie_BarraFixa.Value = Back.BACK_BARRAFIXA_SERIE;
			nSerie_VoadorInverso.Value = Back.BACK_VOADORINVERSO_SERIE;

			nRep_PulleyCostas.Value = Back.BACK_PULLEYCOSTAS_REP;
			nRep_PulleyFrente.Value = Back.BACK_PULLEYFRENTE_REP;
			nRep_PulleyInvertido.Value = Back.BACK_PULLEYINVERTIDO_REP;
			nRep_RemadaHorizontal.Value = Back.BACK_REMADAHORIZONTAL_REP;
			nRep_RemadaAlternada.Value = Back.BACK_REMADAALTERNADA_REP;
			nRep_RemadaCavalinho.Value = Back.BACK_REMADACAVALINHO_REP;
			nRep_PuxadorArticulado.Value = Back.BACK_PUXADORARTICULADO_REP;
			nRep_PeckDeckCostas.Value = Back.BACK_PECKDECK_REP;
			nRep_PullOverCostas.Value = Back.BACK_PULLOVER_REP;
			nRep_BarraFixa.Value = Back.BACK_BARRAFIXA_REP;
			nRep_VoadorInverso.Value = Back.BACK_VOADORINVERSO_REP;

			nCarga_PulleyCostas.Value = Back.BACK_PULLEYCOSTAS_CARGA;
			nCarga_PulleyFrente.Value = Back.BACK_PULLEYFRENTE_CARGA;
			nCarga_PulleyInvertido.Value = Back.BACK_PULLEYINVERTIDO_CARGA;
			nCarga_RemadaHorizontal.Value = Back.BACK_REMADAHORIZONTAL_CARGA;
			nCarga_RemadaAlternada.Value = Back.BACK_REMADAALTERNADA_CARGA;
			nCarga_RemadaCavalinho.Value = Back.BACK_REMADACAVALINHO_CARGA;
			nCarga_PuxadorArticulado.Value = Back.BACK_PUXADORARTICULADO_CARGA;
			nCarga_PeckDeckCostas.Value = Back.BACK_PECKDECK_CARGA;
			nCarga_PullOverCostas.Value = Back.BACK_PULLOVER_CARGA;
			nCarga_BarraFixa.Value = Back.BACK_BARRAFIXA_CARGA;
			nCarga_VoadorInverso.Value = Back.BACK_VOADORINVERSO_CARGA;
			#endregion
			#region Biceps
			cb_RoscaDireta.Text = Biceps.BICEPS_ROSCADIRETA;
			cb_RoscaAlternada.Text = Biceps.BICEPS_ROSCAALTERNADA;
			cb_RoscaMartelo.Text = Biceps.BICEPS_ROSCAMARTELO;
			cb_RoscaConcentrada.Text = Biceps.BICEPS_ROSCACONCENTRADA;
			cb_RoscaArticulada.Text = Biceps.BICEPS_ROSCAARTICULADA;
			cb_RoscaBilateral.Text = Biceps.BICEPS_ROSCABILATERAL;
			cb_RoscaRoldana.Text = Biceps.BICEPS_ROSCAROLDANA;
			cb_RoscaSimultanea.Text = Biceps.BICEPS_ROSCASIMULTANEA;

			nSerie_RoscaDireta.Value = Biceps.BICEPS_ROSCADIRETA_SERIE;
			nSerie_RoscaAlternada.Value = Biceps.BICEPS_ROSCAALTERNADA_SERIE;
			nSerie_RoscaMartelo.Value = Biceps.BICEPS_ROSCAMARTELO_SERIE;
			nSerie_RoscaConcentrada.Value = Biceps.BICEPS_ROSCACONCENTRADA_SERIE;
			nSerie_RoscaArticulada.Value = Biceps.BICEPS_ROSCAARTICULADA_SERIE;
			nSerie_RoscaBilateral.Value = Biceps.BICEPS_ROSCABILATERAL_SERIE;
			nSerie_RoscaRoldana.Value = Biceps.BICEPS_ROSCAROLDANA_SERIE;
			nSerie_RoscaSimultanea.Value = Biceps.BICEPS_ROSCASIMULTANEA_SERIE;

			nRep_RoscaDireta.Value = Biceps.BICEPS_ROSCADIRETA_REP;
			nRep_RoscaAlternada.Value = Biceps.BICEPS_ROSCAALTERNADA_REP;
			nRep_RoscaMartelo.Value = Biceps.BICEPS_ROSCAMARTELO_REP;
			nRep_RoscaConcentrada.Value = Biceps.BICEPS_ROSCACONCENTRADA_REP;
			nRep_RoscaArticulada.Value = Biceps.BICEPS_ROSCAARTICULADA_REP;
			nRep_RoscaBilateral.Value = Biceps.BICEPS_ROSCABILATERAL_REP;
			nRep_RoscaRoldana.Value = Biceps.BICEPS_ROSCAROLDANA_REP;
			nRep_RoscaSimultanea.Value = Biceps.BICEPS_ROSCASIMULTANEA_REP;

			nCarga_RoscaDireta.Value = Biceps.BICEPS_ROSCADIRETA_CARGA;
			nCarga_RoscaAlternada.Value = Biceps.BICEPS_ROSCAALTERNADA_CARGA;
			nCarga_RoscaMartelo.Value = Biceps.BICEPS_ROSCAMARTELO_CARGA;
			nCarga_RoscaConcentrada.Value = Biceps.BICEPS_ROSCACONCENTRADA_CARGA;
			nCarga_RoscaBilateral.Value = Biceps.BICEPS_ROSCAARTICULADA_CARGA;
			nCarga_RoscaRoldana.Value = Biceps.BICEPS_ROSCABILATERAL_CARGA;
			nCarga_RoscaRoldana.Value = Biceps.BICEPS_ROSCAROLDANA_CARGA;
			nCarga_RoscaSimultanea.Value = Biceps.BICEPS_ROSCASIMULTANEA_CARGA;
			#endregion
			#region Chest

			#endregion
			#region Legs

			#endregion
			#region Shouders

			#endregion
			#region Triceps

			#endregion
			#region WarmUp

			#endregion
		}

		private void frm_WorkOut_FormClosed(object sender, FormClosedEventArgs e)
		{
			#region Abs
			Abs.ABS_RETOABDOMEN = "";
			Abs.ABS_INFRA = "";
			Abs.ABS_OBLIQUO = "";
			Abs.ABS_PARALELAFIXA = "";
			Abs.ABS_PRANCHAABDOMEN = "";

			Abs.ABS_RETOABDOMEN_SERIE = 0;
			Abs.ABS_INFRA_SERIE = 0;
			Abs.ABS_OBLIQUO_SERIE = 0;
			Abs.ABS_PARALELAFIXA_SERIE = 0;
			Abs.ABS_PRANCHAABDOMEN_SERIE = 0;

			Abs.ABS_RETOABDOMEN_REP = 0;
			Abs.ABS_INFRA_REP = 0;
			Abs.ABS_OBLIQUO_REP = 0;
			Abs.ABS_PARALELAFIXA_REP = 0;
			Abs.ABS_PRANCHAABDOMEN_REP = 0;

			Abs.ABS_RETOABDOMEN_CARGA = 0;
			Abs.ABS_INFRA_CARGA = 0;
			Abs.ABS_OBLIQUO_CARGA = 0;
			Abs.ABS_PARALELAFIXA_CARGA = 0;
			Abs.ABS_PRANCHAABDOMEN_CARGA = 0;
			#endregion
			#region Back

			#endregion
			#region Biceps

			#endregion
			#region Chest

			#endregion
			#region Legs

			#endregion
			#region Shouders

			#endregion
			#region Triceps

			#endregion
			#region WarmUp

			#endregion
		}
	}
}
