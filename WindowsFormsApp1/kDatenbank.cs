using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class kDatenbank
    {
        DataSet1TableAdapters.BilderTableAdapter bilder = new DataSet1TableAdapters.BilderTableAdapter();
        DataSet1TableAdapters.NotizenTableAdapter notizen = new DataSet1TableAdapters.NotizenTableAdapter();
        DataSet1TableAdapters.KontoTableAdapter konto = new DataSet1TableAdapters.KontoTableAdapter();
        DataSet1TableAdapters.PasswoerterTableAdapter passwoerter = new DataSet1TableAdapters.PasswoerterTableAdapter();

        DataSet1.KontoDataTable Konto = new DataSet1.KontoDataTable();

        public void fillKonto() //Tabelle auslesen und in konto schreiben
        {
            konto.Fill(Konto);
        }

        public void nutzernamKonto()
        {
            DataSet1.KontoRow newRow = (DataSet1.KontoRow)Konto.NewRow(); // cast
            newRow.Benutzername = "s";

            Konto.Rows.Add(newRow);
            konto.Update(Konto);
        }
    }
}
