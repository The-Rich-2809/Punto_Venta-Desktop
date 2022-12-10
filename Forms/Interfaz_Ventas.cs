using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Extgstate;
namespace Entrega_Final
{
    public partial class Interfaz_Ventas : Form
    {
        public string Usuario { get; set; }
        int i = 0;
        public static readonly String IMAGE = @"C:\\Users\\ricar\\Music\\Nueva carpeta\\Entrega_Final\\Resources\\SantanderJiren.png";
        public Interfaz_Ventas()
        {
            InitializeComponent();
        }
        private void Interfaz_Ventas_Load(object sender, EventArgs e)
        {
            Cancelar();
            Dgv_Producto.Columns.Add("IdPRODUCTO", "IdPRODUCTO");
            Dgv_Producto.Columns.Add("EMPRESA", "EMPRESA");
            Dgv_Producto.Columns.Add("NOMBRE", "NOMBRE");
            Dgv_Producto.Columns.Add("DESCRIPCION", "DESCRIPCION");
            Dgv_Producto.Columns.Add("PRECIO", "PRECIO");
            Dgv_Producto.Columns.Add("EXISTENCIA", "EXISTENCIA");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
                buscar();
        }
        private void Btn_Modificar_Pro_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                int RenglonSeleccionado = Dgv_Producto.CurrentRow.Index;
                Nud_Pro.Text = Dgv_Producto.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
                Bloquear(true, false);
            }
            else
            {
                MessageBox.Show("No hay nada a Modificar");
            }

        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = Dgv_Producto.CurrentRow.Index;
            int Cantidad = Convert.ToInt32(Nud_Pro.Text);
            Dgv_Producto.Rows[RenglonSeleccionado].Cells[5].Value = Cantidad;
            int pro = Dgv_Producto.Rows.Count;
            pro--;
            Lbl_Total.Text = Convert.ToString(Sumar(pro));
            Cancelar();
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int i;
            i = Dgv_Producto.Rows.Count;
            if (i > 0)
            {
                int RenglonSeleccionado = Dgv_Producto.CurrentRow.Index;
                string pro = Dgv_Producto.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar el Producto " + pro + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    Dgv_Producto.Rows.RemoveAt(RenglonSeleccionado);
                }
                i--;
                if(i!=0)
                {
                    i--;
                    Lbl_Total.Text = Convert.ToString(Sumar(i));    
                }
                else
                {
                    Lbl_Total.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("No hay nada a Modificar");
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void buscar()
        {
            DataTable dt = new DataTable();
            Ventas ventas = new Ventas();
            Ventas_OPS ventas_OPS = new Ventas_OPS();
            ventas.IdProducto = Code_Pro.Text;
            if (ventas_OPS.ReadAll(ventas))
            {
                dt = ventas_OPS.Mostrar_Pro(ventas);
                i = 1;

                //Eventos para colocar los datos en el datagrid
                string txt_Cantidad;
                int num_Cantidad;
                int pro = Dgv_Producto.Rows.Count;
                int j;
                //Buscar si ya hay un producto con el mismo id
                for (j = 0; j < pro; j++)
                {
                    if (Code_Pro.Text == Dgv_Producto.Rows[j].Cells[0].Value.ToString())
                    {
                        txt_Cantidad = Dgv_Producto.Rows[j].Cells[5].Value.ToString();
                        num_Cantidad = Convert.ToInt32(txt_Cantidad);
                        num_Cantidad++;
                        Dgv_Producto.Rows[j].Cells[5].Value = num_Cantidad;
                        j = pro + 1;
                        pro--;
                    }
                }
                //Cuando no hay ningun producto con el mismo id
                if (j == pro)
                {
                    Dgv_Producto.Rows.Add(dt.Rows[0].ItemArray);
                    Dgv_Producto.Rows[pro].Cells[5].Value = 1;
                }
                Code_Pro.Text = "";

                Lbl_Total.Text = Convert.ToString(Sumar(pro));
            }
        }
        public void Cancelar()
        {
            Bloquear(false, true);
            Nud_Pro.Text = "0";
            Code_Pro.Text = "";
        }
        public void CanVenta()
        {
            Cancelar();
            Lbl_Total.Text = "0";
            Dgv_Producto.Rows.Clear();
            i = 0;
        }
        public void Bloquear(bool i, bool j)
        {
            Nud_Pro.Enabled = i;
            Btn_Modificar.Enabled = i;
            Code_Pro.Enabled = j;
            Btn_Buscar.Enabled = j;
            Btn_Modificar_Pro.Enabled = j;
            Btn_Eliminar.Enabled = j;

        }
        public double Sumar(int pro)
        {
            double total = 0;
            int Cantidad;
            double Precio;
            string Conversion;
            for (int j = 0; j <= pro; j++)
            {
                Conversion = Dgv_Producto.Rows[j].Cells[5].Value.ToString();
                Cantidad = Convert.ToInt32(Conversion);
                Conversion = Dgv_Producto.Rows[j].Cells[4].Value.ToString();
                Precio = Convert.ToDouble(Conversion);
                Precio = Precio * Cantidad;
                total = total + Precio;
            }
            return total;
        }
        public void IPDF(string id, string user)
        {
            //El PDF se genera con una utileria llamad iText, la cual se tiene que incluir antes de utilizar.
            //para instalar ir a Herramientas -> admininistrador de paquetes Nuget -> Consola del administrador de paquetes Nuget
            //en el prompot pm> teclear el comando Install-Package itext7, dar enter y esperar

            //Mas información en https://kb.itextpdf.com/home/it7kb/examples
            //este es un ejemplo básico.

            Ventas ventas = new Ventas();
            SaveFileDialog GuardaArchivoPdf = new SaveFileDialog();
            string rp = @"Ticket No " + id + " " + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            GuardaArchivoPdf.Filter = "Archivos PDF|*.pdf";
            GuardaArchivoPdf.FileName = rp;
            if (GuardaArchivoPdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(GuardaArchivoPdf.FileName, FileMode.Create))
                {
                    PdfWriter pdfWriter = new PdfWriter(stream);
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    PageSize pageSize = PageSize.A7.Rotate();
                    
                    Document MiDocumento = new Document(pdfDocument);
                    PdfCanvas canvas = new PdfCanvas(pdfDocument.AddNewPage());

                    Table TblVenta = new Table(UnitValue.CreatePercentArray(6));

                    MiDocumento.Add(new Paragraph("Ticket No " + id + " " + DateTime.Now.ToLongDateString()));

                    if (Dgv_Producto.RowCount > 0)
                    {
                        for (int i = 0; i < Dgv_Producto.Columns.Count; i++)
                        {
                            TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Columns[i].Name)));
                        }
                        for (int row = 0; row < Dgv_Producto.RowCount; row++)
                        {

                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[0].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[1].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[2].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[3].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[4].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(Dgv_Producto.Rows[row].Cells[5].Value.ToString()).SetMargins(0, 0, 0, 0)));
                        }
                        MiDocumento.Add(TblVenta);
                        MiDocumento.Add(new Paragraph("El total de la compra fue de $ " + Lbl_Total.Text+" MXN"));
                        MiDocumento.Add(new Paragraph("Que tenga excelente dia :V \n Lo antendio " + user));
                        canvas.AddImageFittedIntoRectangle(ImageDataFactory.Create(IMAGE),pageSize, false);

                    }
                    else
                    {
                        TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph("Error")));
                        TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph("No hay usuarios por listar")));
                        MiDocumento.Add(TblVenta);

                    }
                    MiDocumento.Close();
                }
            }
        }

        private void Btn_Terminar_Click(object sender, EventArgs e)
        {
            Ventas Venta = new Ventas();
            Ventas_OPS OPS = new Ventas_OPS();
            int i = 0;


            if (Lbl_Total.Text != "0")
            {
                DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    for (i = 0; i < Dgv_Producto.RowCount; i++)
                    {
                        string id = Dgv_Producto.Rows[i].Cells[0].Value.ToString();
                        int Ex_Inicial = Convert.ToInt32(OPS.Extraer_Catidad(id));
                        int Ex_Comprada = Convert.ToInt32(Dgv_Producto.Rows[i].Cells[5].Value.ToString());
                        int Ex_Final = Ex_Inicial - Ex_Comprada;
                        if (Ex_Final < 0)
                        {
                            string producto = Dgv_Producto.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show("Lo sentimos, no contamos con las cantidades solicitadas del producto "+producto+"\nSolo tenemos disponibles "+Ex_Inicial+" piezas disponibles");
                            i = Dgv_Producto.RowCount + 1;
                        }
                    }

                    if (i == Dgv_Producto.RowCount)
                    {
                        for (i = 0; i < Dgv_Producto.RowCount; i++)
                        {
                            string id = Dgv_Producto.Rows[i].Cells[0].Value.ToString();
                            int Ex_Inicial = Convert.ToInt32(OPS.Extraer_Catidad(id));
                            int Ex_Comprada = Convert.ToInt32(Dgv_Producto.Rows[i].Cells[5].Value.ToString());
                            int Ex_Final = Ex_Inicial - Ex_Comprada;
                            string ex_F = Convert.ToString(Ex_Final);
                            OPS.Mod_Ex_PRO(ex_F, id);
                        }

                        Venta.User = Usuario;
                        Venta.CveEmpleado = OPS.Extraer_Empleado(Venta);
                        Venta.IdVentas = OPS.generaIdVenta();
                        Venta.Importe = Convert.ToInt32(Lbl_Total.Text);
                        Venta.Fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");
                        OPS.New_Venta(Venta);
                        Resultado = MessageBox.Show("¿Desea Ticket?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (Resultado == DialogResult.Yes)
                        {
                            IPDF(Convert.ToString(Venta.IdVentas), Usuario);
                        }

                        CanVenta();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede facturar con importe de $ 0 ");
            }
        }
        private void Btn_Can_Venta_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Desea cancelar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                CanVenta();
            }
        }
    }
}
