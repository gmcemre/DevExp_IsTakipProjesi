using DevExp_IsTakipProjesi.Entity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExp_IsTakipProjesi.Formlar
{
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.Id,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar dep = new TblDepartmanlar();
            dep.Ad = txtAd.Text;
            db.TblDepartmanlar.Add(dep);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
