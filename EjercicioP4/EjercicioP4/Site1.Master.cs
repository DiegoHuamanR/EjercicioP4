using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioP4
{

    public partial class Site1 : System.Web.UI.MasterPage
    {
        String seleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem microondas = new ListItem("Microondas", "20");
                objetos.Items.Add(microondas);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            seleccionado = objetos.SelectedItem.ToString();
            if (seleccionado == "Lavadora")
            {
     
                grafico.Src = "" + objetos.SelectedItem.ToString() + ".jpg";
                grafico.Visible = true;
                codigo.Text = "15632";
                nombre.Text = "Lavadora";
                descripcion.Text = "Es un equipo eléctrico que facilita el lavado de la ropa";
                marca.Text = "LG";
                precio.Text = "S/.899";


            }
            if (seleccionado == "Microondas")
            {
                s1.Text = seleccionado;
                grafico.Src = "" + objetos.SelectedItem.ToString() + ".jpg";
                grafico.Visible = true;
                codigo.Text = "15633";
                nombre.Text = "Microondas";
                descripcion.Text = "Aparato eléctrico que permite la cocción o el calentamiento de alimentos";
                marca.Text = "Samsung";
                precio.Text = "S/.489";
            }
            if (seleccionado == "Cocina")
            {
                s1.Text = seleccionado;
                grafico.Src = "" + objetos.SelectedItem.ToString() + ".jpg";
                grafico.Visible = true;
                codigo.Text = "15634";
                nombre.Text = "Cocina";
                descripcion.Text = "Aparato eléctrico que permite calentar los alimentos";
                marca.Text = "LG";
                precio.Text = "S/.1799";

            }
            if (seleccionado == "Plancha")
            {
                s1.Text = seleccionado;
                grafico.Src = "" + objetos.SelectedItem.ToString() + ".jpg";
                grafico.Visible = true;
                codigo.Text = "15634";
                nombre.Text = "Cocina";
                descripcion.Text = "Electrodomestico que sirve para alisar la ropa";
                marca.Text = "Philips";
                precio.Text = "S/.146";
            }
        }
    }
    }
