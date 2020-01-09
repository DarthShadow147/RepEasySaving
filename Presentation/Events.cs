using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class Events : Form
    {
        EventsModel registro = new EventsModel();

        public Events()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarEventos()
        {
            EventsModel events = new EventsModel();
            DataGridEvents.DataSource = events.ShowEvents();
        }

        private void ListarResumen()
        {
            EventsModel summary = new EventsModel();
            DataGridBinnacle.DataSource = summary.ShowBinacle(txtIdEvento.Text);
        }

        private void Events_Load(object sender, EventArgs e)
        {
            ListarEventos();
            ListarResumen();
            Format();
            this.ReportSettlement.RefreshReport();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                registro.InsertEvents(txtName.Text,txtInversion.Text,txtParticipants.Text);
                MessageBox.Show("Se registro correctamente.");
                ListarEventos();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }
        }

        public void Clear()
        {
            txtIdEvento.Clear();
            txtName.Clear();
            txtInversion.Clear();
            txtParticipants.Clear();
            txtDescription.Clear();
            CheckSpending.Checked = false; 
            txtAmount.Clear();
            DataGridBinnacle.DataSource = null;
        }

        public void Clear2()
        {
            txtDescription.Clear();
            CheckSpending.Checked = false;
            txtAmount.Clear();
        }

        public void Format()
        {
            //EventName,Inversion,NumberParticipants

            DataGridEvents.Columns["EventName"].HeaderText = "Evento";
            DataGridEvents.Columns["Inversion"].HeaderText = "Inversion";
            DataGridEvents.Columns["NumberParticipants"].HeaderText = "Participantes";


            this.DataGridEvents.Columns["Inversion"].DefaultCellStyle.Format = "c0";
            this.DataGridEvents.Columns["Inversion"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridEvents.Columns.Count - 1; i++)
            {
                DataGridEvents.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridEvents.Columns[DataGridEvents.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridEvents.Columns.Count; i++)
            {
                int colw = DataGridEvents.Columns[i].Width;
                DataGridEvents.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridEvents.Columns[i].Width = colw;
            }



            //EventId,Description,DateBinnacle,Spending,AmountEvent
            DataGridBinnacle.Columns["EventId"].HeaderText = "Id Evento";
            DataGridBinnacle.Columns["Description"].HeaderText = "Descripcion";
            DataGridBinnacle.Columns["DateBinnacle"].HeaderText = "Fecha";
            DataGridBinnacle.Columns["Spending"].HeaderText = "Tipo";
            DataGridBinnacle.Columns["AmountEvent"].HeaderText = "Valor";

            this.DataGridBinnacle.Columns["AmountEvent"].DefaultCellStyle.Format = "c0";
            this.DataGridBinnacle.Columns["AmountEvent"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CO");

            for (int i = 0; i < DataGridBinnacle.Columns.Count - 1; i++)
            {
                DataGridBinnacle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            DataGridBinnacle.Columns[DataGridBinnacle.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < DataGridBinnacle.Columns.Count; i++)
            {
                int colw = DataGridBinnacle.Columns[i].Width;
                DataGridBinnacle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGridBinnacle.Columns[i].Width = colw;
            }
        }

        private void btnRegBinnacle_Click(object sender, EventArgs e)
        {
            try
            {
                registro.InsertBinnacle(txtIdEvento.Text, txtDescription.Text, CheckSpending.Checked.ToString(), txtAmount.Text);
                MessageBox.Show("Se registro correctamente.");
                ListarResumen();
                Clear2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DataGridEvents.SelectedRows.Count > 0)
            {
                txtIdEvento.Text = DataGridEvents.CurrentRow.Cells["EventId"].Value.ToString();
                ListarResumen();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea realizar la liquidación del Evento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    registro.SettlementEvent(txtIdEvento.Text);
                    var EventId = txtIdEvento.Text;
                    GetReport(EventId);
                    GetBinnacle(EventId);
                    GetTotal(EventId);
                    MessageBox.Show("Se registro correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pueden insertar los datos por: " + ex);
                }
            }
        }

        private void GetReport(string EventId)
        {
            EventsModel report = new EventsModel();
            report.ShowReport(EventId);

            settlementEventsBindingSource.DataSource = report;
            settlementEventsBindingSource.DataSource = report.ReportSettlementEvent;
            this.ReportSettlement.RefreshReport();
        }

        private void GetBinnacle(string EventId)
        {
            EventsModel report = new EventsModel();
            report.ShowBinnacle(EventId);

            summayBinnacleBindingSource.DataSource = report;
            summayBinnacleBindingSource.DataSource = report.ReportBinnacleEvent;
            this.ReportSettlement.RefreshReport();
        }

        private void GetTotal(string EventId)
        {
            EventsModel report = new EventsModel();
            report.ShowTotalEvent(EventId);

            totalBinnacleBindingSource.DataSource = report;
            totalBinnacleBindingSource.DataSource = report.ReportTotalEvents;
            this.ReportSettlement.RefreshReport();
        }

        private void btnPruebasReport_Click(object sender, EventArgs e)
        {
            GetReport(txtIdEvento.Text);
            GetBinnacle(txtIdEvento.Text);
            GetTotal(txtIdEvento.Text);
        }
    }
}
