using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilari_odev2
{
    public partial class Form1 : Form
    {
        Node headNode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbSonaEkle.Checked)
            {
                Kontrol();
                if ((txtOrt.Text != "") && (txtNo.Text != "") && (txtAd.Text != ""))
                {
                    AddToEnd(Convert.ToInt32(txtNo.Text), txtAd.Text, Convert.ToDouble(txtOrt.Text));
                    printList1();
                    Temizle();
                    rbSonaEkle.Checked = false;
                }
            }
            if (rbBasaEkle.Checked)
            {
                Kontrol();
                if ((txtOrt.Text != "") && (txtNo.Text != "") && (txtAd.Text != ""))
                {
                    AddToBeginning(Convert.ToInt32(txtNo.Text), txtAd.Text, Convert.ToDouble(txtOrt.Text));
                    printList1();
                    Temizle();
                    rbBasaEkle.Checked = false;
                }
            }
            if (rbSirayaEkle.Checked)
            {
                Kontrol();
                if ((txtOrt.Text != "") && (txtNo.Text != "") && (txtAd.Text != ""))
                {
                    AddToBeginning(Convert.ToInt32(txtNo.Text), txtAd.Text, Convert.ToDouble(txtOrt.Text));
                    AddSorted();
                    Temizle();
                    rbSirayaEkle.Checked = false;
                }
            }
            LabelKontrol();
        }
        void LabelKontrol()
        {
            if (Boyut() == 0)
            {
                lblListeBos.Visible = true;
                lblListeBos.Text = "Liste Boş";
            }
            if(Boyut()!=0)
            {
                lblListeBos.BackColor = Color.LightGreen;
                lblListeBos.Text = "Listede "+Boyut()+" kişi var.";
               // lblListeBos.Visible = false;
            }
        }
        public void AddToBeginning(int data, string name, double gpa)
        {
            Node yeni = new Node(data, name, gpa);
            Node[] dizi = Dizi();
            bool varMi = false, buyukMu = false;
            for (int i = 0; i < Boyut(); i++)
            {
                if (dizi[i].no == data)
                {
                    MessageBox.Show("Bu numaralı öğrenci listede mevcut.");
                    Temizle();
                    varMi = true;
                    break;
                }
            }
            if (gpa > 100)
            {
                MessageBox.Show("Not ortalaması 100'den fazla olamaz.");
                Temizle();
                buyukMu = true;

            }
            if ((varMi == false) && (buyukMu == false))
            {
                if (headNode == null)
                    headNode = new Node(data, name, gpa);
                else
                {
                    Node temp = new Node(data, name, gpa);
                    temp.next = headNode;
                    headNode = temp;
                }
            }
        }
        public void AddToEnd(int data, string name, double gpa)
        {
            Node yeni = new Node(data, name, gpa);
            Node[] dizi = Dizi();
            bool varMi = false, buyukMu = false;
            for (int i = 0; i < Boyut(); i++)
            {
                if (dizi[i].no == data)
                {
                    MessageBox.Show("Bu numaralı öğrenci listede mevcut.");
                    Temizle();
                    varMi = true;
                    break;
                }
            }
            if (gpa > 100)
            {
                MessageBox.Show("Not ortalaması 100'den fazla olamaz.");
                Temizle();
                buyukMu = true;
            }
            if ((varMi == false) && (buyukMu == false))
            {
                if (headNode == null)
                    headNode = new Node(data, name, gpa);
                else
                {
                    //AddToEnd(data,name);
                    yeni.next = null;
                    Node son = headNode;
                    while (son.next != null)
                        son = son.next;
                    son.next = yeni;
                    return;
                }
            }
        }
        public void AddSorted()
        {
            // Node tempNode = headNode;
            Node[] dizi = NoSiralama();
            listBox1.Items.Clear();
            for (int i = 0; i < Boyut(); i++)
                listBox1.Items.Add(dizi[i].no + " " + dizi[i].isim + " " + dizi[i].ort);
        }
        void printList1()
        {
            listBox1.Items.Clear();
            Node node = headNode;
            while (node != null)
            {
                listBox1.Items.Add(node.no + " " + node.isim + " " + node.ort);
                node = node.next;
            }
        }
        void printList2(Node[] dizi)
        {
            //Node tempNode = headNode;
            listBox2.Items.Clear();
            for (int i = 0; i < Boyut(); i++)
                listBox2.Items.Add(dizi[i].no + " " + dizi[i].isim + " " + dizi[i].ort);
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (rbBasSil.Checked)
            {
                headNode = headNode.next;
                MessageBox.Show("Kişi silindi.");
                printList1();
                rbBasSil.Checked = false;
            }
            if (rbSonSil.Checked)
            {
                RemoveLast();
                printList1();
                rbSonSil.Checked = false;
            }
            if (rbTumSil.Checked)
            {
                headNode = null;
                printList1();
                listBox2.Items.Clear();
                rbTumSil.Checked = false;
            }
            if (rbNoSil.Checked)
            {
                RemoveNumber(Convert.ToInt32(txtNo.Text));
                printList1();
                rbNoSil.Checked = false;
            }
            if (rbSiraSil.Checked)
            {
                RemoveOrder(Convert.ToInt32(txtsira.Text));
                printList1();
                rbSiraSil.Checked = false;
                txtsira.Clear();
            }
            LabelKontrol();
        }
        public void RemoveLast()
        {

            if (headNode == null) //Liste boş
                MessageBox.Show("Listeniz boş");
            else if (headNode.next == null) //Sadece 1 eleman varsa
            {
                headNode = null;
                MessageBox.Show("Kişi silindi.");

            }
            else //2 ve 2den fazla eleman varsa
            {
                Node tempNode = headNode;

                while (true)
                {
                    if (tempNode.next.next == null)
                    {
                        tempNode.next = null;
                        break;
                    }
                    tempNode = tempNode.next;
                }
                MessageBox.Show("Kişi silindi.");
            }
        }
        public void RemoveNumber(int number) //ruh hali karmaşık
        {
            Node tempNode = headNode;
            Node prevNode = headNode;
            if (headNode == null) //Liste boş
                MessageBox.Show("Listeniz boş");
            else if (headNode.next == null) //Sadece 1 eleman varsa
            {
                if (headNode.no == number)
                {
                    headNode = null;
                    MessageBox.Show("Kişi silindi.");
                    txtNo.Clear();
                }
                else
                {
                    MessageBox.Show("Böyle bir numara yok.");
                    txtNo.Clear();
                }

                }
            else //2 ve 2den fazla eleman varsa
            {
                while (tempNode != null && tempNode.no != number)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                }
                prevNode.next = tempNode.next;
                MessageBox.Show("Kişi silindi.");
                txtNo.Clear();
            }

        }
        public void RemoveOrder(int number)
        {

            if (headNode == null) //Liste boş
                MessageBox.Show("Listeniz boş");
            else
            {
                Node tempNode = headNode;

                if (number == 0)
                {
                    headNode = tempNode.next;
                    MessageBox.Show("Kişi silindi.");
                }

                for (int i = 0; tempNode != null && i < number - 1; i++)
                    tempNode = tempNode.next;

                if ((tempNode == null || tempNode.next == null)&&(number!=0))
                    MessageBox.Show("Böyle bir sıra yok.");

               // Node next = tempNode.next.next;
               if(number!=0)
                tempNode.next = tempNode.next.next;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (rbNoListele.Checked)
            {
                printList2(NoSiralama());
                rbNoListele.Checked = false;
            }
            if (rbAdListele.Checked)
            {
                printList2(IsimSiralama());
                rbAdListele.Checked = false;
            }
            if (rbOrtListele.Checked)
            {
                printList2(OrtSiralama());
                rbOrtListele.Checked = false;
            }
        }

        private void btnListeBoyutu_Click(object sender, EventArgs e)
        {
            lblListeBoyutu.Text = "" + Boyut().ToString();
        }
        int Boyut()
        {
            Node tempNode = headNode;
            int i = 0;
            while (tempNode != null)
            {
                tempNode = tempNode.next;
                i++;
            }
            return i;
        }
        Node[] Dizi()
        {
            Node[] dizi;
            Node tempNode = headNode;
            dizi = new Node[Boyut()];
            for (int i = 0; i < Boyut(); i++)
            {
                dizi[i] = tempNode;
                tempNode = tempNode.next;
            }
            return dizi;

        }
        Node[] OrtSiralama()
        {

            Node prevNode;
            Node[] dizi = Dizi();
            for (int i = 0; i < Boyut(); i++)
            {
                for (int j = 0; j < Boyut(); j++)
                {
                    if (dizi[i].ort > dizi[j].ort)
                    {
                        prevNode = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = prevNode;
                    }
                }
            }
            return dizi;
        }
        Node[] NoSiralama()
        {
            Node prevNode;
            Node[] dizi = Dizi();
            for (int i = 0; i < Boyut(); i++)
            {
                for (int j = 0; j < Boyut(); j++)
                {
                    if (dizi[i].no < dizi[j].no)
                    {
                        prevNode = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = prevNode;
                    }
                }
            }
            return dizi;
        }
        Node[] IsimSiralama()
        {
            Node tempNode = headNode, prevNode;
            string[] Isim = new string[Boyut()];
            Node[] dizi = Dizi();
            for (int i = 0; i < Boyut(); i++)
            {
                Isim[i] = tempNode.isim;
                tempNode = tempNode.next;
            }
            Array.Sort(Isim);
            for (int i = 0; i < Boyut(); i++)
            {
                for (int j = 0; j < Boyut(); j++)
                {
                    if (dizi[i].isim == Isim[j])
                    {
                        prevNode = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = prevNode;
                    }
                }
            }
            return dizi;
        }
        void Temizle()
        {
            txtAd.Clear();
            txtNo.Clear();
            txtOrt.Clear();
        }
        void Kontrol()
        {
            if (txtAd.Text == "")
                MessageBox.Show("Lütfen öğrenci adını giriniz.");
            if (txtNo.Text == "")
                MessageBox.Show("Lütfen öğrenci numarasını giriniz.");
            if (txtOrt.Text == "")
                MessageBox.Show("Lütfen öğrencinin ortalamasını giriniz.");
        }
    }
}
