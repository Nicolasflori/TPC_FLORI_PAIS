﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace TPC_FLORI_PAIS.ABM.ProductosPreCargados
{
    public partial class ProductosPreCargados_Det : System.Web.UI.Page
    {
        NegocioCategorias negocioCategorias = new NegocioCategorias();
        NegocioColores negocioColores = new NegocioColores();
        NegocioEstampado negocioEstampado = new NegocioEstampado();
        NegocioProductoPreCargado negocioProductoPreCargado = new NegocioProductoPreCargado();

        List<Categoria> listaCategoria = new List<Categoria>();
        List<Color> listaColores = new List<Color>();
        List<Estampado> listaEstampado = new List<Estampado>();
        List<ProductoPreCargado> listaProductoPreCargado = new List<ProductoPreCargado>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaColores = negocioColores.listar();

            ListItem b;
            foreach (Color item in listaColores)
            {
                b = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListColores.Items.Add(b);
            }
           
            
            listaCategoria = negocioCategorias.listar();
            ListItem a;
            foreach (Categoria item in listaCategoria)
            {
                a = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListCategoria.Items.Add(a);
            }
            

            listaEstampado = negocioEstampado.listar();

            ListItem c;
            foreach (Estampado item in listaEstampado)
            {
                c = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListEstampados.Items.Add(c);
            }

            int idProductoPreCargado= int.Parse(Request.QueryString["id"]);

            listaProductoPreCargado = negocioProductoPreCargado.listar();
            ProductoPreCargado seleccionado = listaProductoPreCargado.Find(x => x.ID == idProductoPreCargado);
            DropDownListColores.SelectedIndex= seleccionado.IDColor-1;
            DropDownListCategoria.SelectedIndex = seleccionado.IDCategoria - 1;
            DropDownListEstampados.SelectedIndex = seleccionado.IDEstampado - 1;


        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idproductoPreCargado = int.Parse(Request.QueryString["id"]);
            ProductoPreCargado productoPreCargado = new ProductoPreCargado()
            {
                ID = idproductoPreCargado,
                IDColor = DropDownListColores.SelectedIndex+1,
                IDCategoria = DropDownListCategoria.SelectedIndex + 1,
                IDEstampado = DropDownListEstampados.SelectedIndex + 1

            };
            negocioProductoPreCargado.modificar(productoPreCargado);

            Response.Redirect("ProductosPreCargados.aspx");

        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idProductoPreCargado = int.Parse(Request.QueryString["id"]);
            negocioProductoPreCargado.eliminar(idProductoPreCargado);

            Response.Redirect("ProductosPreCargados.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosPreCargados.aspx");
        }
    }
}