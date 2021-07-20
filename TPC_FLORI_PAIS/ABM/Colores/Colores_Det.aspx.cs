using System;
using Dominio;
using Negocio;

namespace TPC_FLORI_PAIS.ABM.Colores
{
    public partial class Colores_Det : System.Web.UI.Page
    {
        NegocioColores NegocioColores = new Negocio.NegocioColores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_Descripcion.Text = NegocioColores.descripcionxid(int.Parse(Request.QueryString["id"]));
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idColor = int.Parse(Request.QueryString["id"]);
            Color color = new Color() {
                ID=idColor,
                Descripcion= txt_Descripcion.Text
            };
            NegocioColores.modificar(color);

            Response.Redirect("Colores.aspx");
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        CargarDatosUsuario();

        //        CargarOrigenes();

        //        CargarProducto();

        //        Cargar_Proveedores();

        //        Cargar_DDL_Proveedores();

        //        Cargar_Grilla_Imagenes();

        //        if (this.lbl_idRol.Text == "4") //Operarios
        //        {
        //            //this.btn_LlamarEliminar.Visible = false;
        //            this.btn_Modificar.Visible = false;
        //        }
        //    }

        //}

        //protected void CargarOrigenes()
        //{
        //    #region .. Origenes ..
        //    //Origenes
        //    //
        //    Database db3 = DatabaseFactory.CreateDatabase("Sql");
        //    string sqlCommand3 = "SELECT idOrigen, Origen FROM Origenes WHERE idEntidad=@idEntidad AND idCentro = @idCentro and eliminado='0' ORDER BY Origen";
        //    DbCommand dbc3 = db3.GetSqlStringCommand(sqlCommand3);

        //    db3.AddInParameter(dbc3, "idEntidad", DbType.String, lbl_idEntidad.Text);
        //    db3.AddInParameter(dbc3, "idCentro", DbType.String, lbl_idCentro.Text);

        //    DataSet ds3 = db3.ExecuteDataSet(dbc3);

        //    DataRow r3 = null;
        //    r3 = ds3.Tables[0].NewRow();
        //    r3["idOrigen"] = 0;
        //    r3["Origen"] = "(Seleccionar)";
        //    ds3.Tables[0].Rows.InsertAt(r3, 0);


        //    this.ddl_Origen.DataSource = ds3;
        //    this.ddl_Origen.DataTextField = "Origen";
        //    this.ddl_Origen.DataValueField = "idOrigen";
        //    this.ddl_Origen.DataBind();
        //    #endregion

        //}

        //protected void CargarDatosUsuario()
        //{
        //    Usuario user = new Usuario(Page.User.Identity.Name);

        //    this.lbl_idEntidad.Text = user.idEntidad;
        //    this.lbl_idCentro.Text = user.idCentro;
        //    this.lbl_idRol.Text = user.idRol;

        //}

        //protected void CargarProducto()
        //{
        //    string idProducto = Request.QueryString["id"];

        //    Database db_1 = DatabaseFactory.CreateDatabase("Sql");
        //    string sqlCommand_1 = "SELECT * FROM Productos WHERE idProducto=@idProducto";
        //    DbCommand dbc_1 = db_1.GetSqlStringCommand(sqlCommand_1);

        //    db_1.AddInParameter(dbc_1, "idProducto", DbType.String, idProducto);

        //    DataSet ds = db_1.ExecuteDataSet(dbc_1);

        //    this.txt_CodigoProducto.Text = ds.Tables[0].Rows[0]["LITM"].ToString(); //WRIN

        //    this.txt_Descripcion.Text = ds.Tables[0].Rows[0]["DSC"].ToString();
        //    this.txt_Kilos.Text = ds.Tables[0].Rows[0]["Kilos"].ToString();
        //    this.txt_M3.Text = ds.Tables[0].Rows[0]["m3"].ToString();
        //    this.txt_FactPal.Text = ds.Tables[0].Rows[0]["factpal"].ToString();
        //    this.txt_Familia.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
        //    //this.txt_Tipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
        //    this.txt_UnidadCaja.Text = ds.Tables[0].Rows[0]["UnidadesPorCaja"].ToString();
        //    this.txt_UnidadMedida.Text = ds.Tables[0].Rows[0]["UOM"].ToString();
        //    this.txt_FechaActualizacion.Text = ds.Tables[0].Rows[0]["fec_actualizado"].ToString();
        //    //this.txt_Rnpe.Text = ds.Tables[0].Rows[0]["Rnpe"].ToString();
        //    //this.txt_Rppa.Text = ds.Tables[0].Rows[0]["Rppa"].ToString();
        //    this.txt_OtrosRegistros.Text = ds.Tables[0].Rows[0]["OtrosRegistros"].ToString();

        //    this.ddl_Origen.SelectedValue = ds.Tables[0].Rows[0]["idOrigen"].ToString();

        //    this.txt_EnvasePrimario.Text = ds.Tables[0].Rows[0]["EnvBulto"].ToString();

        //    this.txt_KgNeto.Text = ds.Tables[0].Rows[0]["NetoUnidad"].ToString();
        //    this.txt_UnidadPrimaria.Text = ds.Tables[0].Rows[0]["UnidadBolsa"].ToString();
        //    this.txt_UnidadSecundaria.Text = ds.Tables[0].Rows[0]["UnidadBulto"].ToString();
        //    this.txt_Conservacion_VidaUtil.Text = ds.Tables[0].Rows[0]["VidaUtil"].ToString();
        //    this.txt_Conservacion_TempMinima.Text = ds.Tables[0].Rows[0]["TMin"].ToString();
        //    this.txt_Conservacion_TempMaxima.Text = ds.Tables[0].Rows[0]["TMax"].ToString();
        //    this.txt_Conservacion_Observacion.Text = ds.Tables[0].Rows[0]["Observacion"].ToString();
        //    this.txt_PaisOrigen.Text = ds.Tables[0].Rows[0]["Pais_Origen"].ToString();
        //    this.txt_limiteCritico.Text = ds.Tables[0].Rows[0]["LimiteCritico"].ToString();
        //    this.txt_Ingredientes.Text = ds.Tables[0].Rows[0]["Ingredientes"].ToString();
        //    this.txt_PorcVidaUtil.Text = ds.Tables[0].Rows[0]["Porcentaje"].ToString();

        //    this.txt_NumeroProductoAlimenticio.Text = ds.Tables[0].Rows[0]["NroProdAlimenticio"].ToString();
        //    this.txt_Alergenos.Text = ds.Tables[0].Rows[0]["Alergenos"].ToString();
        //    this.txt_Establecimiento.Text = ds.Tables[0].Rows[0]["NroEstablecimiento"].ToString();

        //    if (ds.Tables[0].Rows[0]["Valida_Temperatura"].ToString() == "SI")
        //        this.cb_Valida_Temp.Checked = true;
        //    else
        //        this.cb_Valida_Temp.Checked = false;


        //    if (ds.Tables[0].Rows[0]["Valida_VidaUtil"].ToString() == "SI")
        //        this.cb_Valida_VidaUtil.Checked = true;
        //    else
        //        this.cb_Valida_VidaUtil.Checked = false;


        //    try
        //    {
        //        this.ddl_Alimento.SelectedValue = ds.Tables[0].Rows[0]["Alimento"].ToString();
        //    }
        //    catch { }

        //    //Valida que QUIMICO y SECO no puedan cargar Temp
        //    //
        //    if (ds.Tables[0].Rows[0]["tipo"].ToString() == "S" || ds.Tables[0].Rows[0]["tipo"].ToString() == "Q")
        //    {
        //        this.cb_Valida_Temp.Enabled = false;
        //        this.cb_Valida_Temp.Checked = false;
        //    }

        //    this.txt_STKT.Text = ds.Tables[0].Rows[0]["STKT"].ToString();

        //    if (ds.Tables[0].Rows[0]["TipoProducto"].ToString() != "" && ds.Tables[0].Rows[0]["TipoProducto"].ToString() != null)
        //    {
        //        this.ddl_TipoProducto.Text = ds.Tables[0].Rows[0]["TipoProducto"].ToString();
        //    }


        //    this.txt_PuntoReapro.Text = ds.Tables[0].Rows[0]["PuntoReapro"].ToString();

        //}

        //protected void btn_Modificar_Click(object sender, EventArgs e)
        //{
        //    string idProducto = Request.QueryString["id"];

        //    Database db = DatabaseFactory.CreateDatabase("Sql");
        //    string sqlCommand = "UPDATE Productos SET  fec_actualizado=@fec_actualizado, Alimento=@Alimento, Porcentaje=@Porcentaje, "
        //            + " OtrosRegistros=@OtrosRegistros, idOrigen=@idOrigen, "
        //            + " EnvBulto=@EnvBulto, NetoUnidad=@NetoUnidad, "
        //            + " UnidadBolsa=@UnidadBolsa,  UnidadBulto=@UnidadBulto , VidaUtil=@VidaUtil, TMin=@TMin, TMax=@TMax, "
        //            + " Observacion=@Observacion, limiteCritico=@limiteCritico, Ingredientes=@ingredientes, "
        //            + " Pais_Origen=@Pais_Origen, NroProdAlimenticio=@NroProdAlimenticio, Alergenos=@Alergenos, NroEstablecimiento=@NroEstablecimiento  "
        //            + " , Valida_Temperatura=@Valida_Temperatura, Valida_VidaUtil=@Valida_VidaUtil "
        //            + " , TipoProducto=@TipoProducto, PuntoReapro=@PuntoReapro "
        //            + " WHERE idProducto=@idProducto"; //Rnpe=@Rnpe, Rppa=@Rppa

        //    DbCommand dbc = db.GetSqlStringCommand(sqlCommand);

        //    db.AddInParameter(dbc, "fec_actualizado", DbType.Date, DateTime.Now);
        //    //db.AddInParameter(dbc, "Rnpe", DbType.String, this.txt_Rnpe.Text);
        //    //db.AddInParameter(dbc, "Rppa", DbType.String, this.txt_Rppa.Text);
        //    db.AddInParameter(dbc, "OtrosRegistros", DbType.String, this.txt_OtrosRegistros.Text);

        //    if (this.ddl_Origen.SelectedValue.ToString() == "0")
        //    {
        //        db.AddInParameter(dbc, "idOrigen", DbType.String, DBNull.Value);
        //    }
        //    else
        //    {
        //        db.AddInParameter(dbc, "idOrigen", DbType.String, this.ddl_Origen.SelectedValue.ToString());
        //    }
        //    db.AddInParameter(dbc, "EnvBulto", DbType.String, this.txt_EnvasePrimario.Text);
        //    db.AddInParameter(dbc, "Pais_Origen", DbType.String, this.txt_PaisOrigen.Text);
        //    db.AddInParameter(dbc, "Alimento", DbType.String, this.ddl_Alimento.SelectedValue);
        //    db.AddInParameter(dbc, "NroProdAlimenticio", DbType.String, this.txt_NumeroProductoAlimenticio.Text);
        //    db.AddInParameter(dbc, "Alergenos", DbType.String, this.txt_Alergenos.Text);
        //    db.AddInParameter(dbc, "NroEstablecimiento", DbType.String, this.txt_Establecimiento.Text);

        //    if (this.txt_PorcVidaUtil.Text != "")
        //        db.AddInParameter(dbc, "Porcentaje", DbType.Decimal, this.txt_PorcVidaUtil.Text);
        //    else
        //        db.AddInParameter(dbc, "Porcentaje", DbType.Decimal, DBNull.Value);

        //    if (this.txt_KgNeto.Text != "")
        //        db.AddInParameter(dbc, "NetoUnidad", DbType.Decimal, this.txt_KgNeto.Text);
        //    else
        //        db.AddInParameter(dbc, "NetoUnidad", DbType.Decimal, DBNull.Value);

        //    if (this.txt_UnidadSecundaria.Text != "")
        //        db.AddInParameter(dbc, "UnidadBulto", DbType.Decimal, this.txt_UnidadSecundaria.Text);
        //    else
        //        db.AddInParameter(dbc, "UnidadBulto", DbType.Decimal, DBNull.Value);


        //    if (this.txt_UnidadPrimaria.Text != "")
        //        db.AddInParameter(dbc, "UnidadBolsa", DbType.Decimal, this.txt_UnidadPrimaria.Text);
        //    else
        //        db.AddInParameter(dbc, "UnidadBolsa", DbType.Decimal, DBNull.Value);

        //    if (this.txt_Conservacion_VidaUtil.Text != "")
        //        db.AddInParameter(dbc, "VidaUtil", DbType.Int32, this.txt_Conservacion_VidaUtil.Text);
        //    else
        //        db.AddInParameter(dbc, "VidaUtil", DbType.Int32, DBNull.Value);

        //    if (this.txt_Conservacion_TempMinima.Text != "")
        //        db.AddInParameter(dbc, "TMin", DbType.Decimal, this.txt_Conservacion_TempMinima.Text);
        //    else
        //        db.AddInParameter(dbc, "TMin", DbType.Decimal, DBNull.Value);

        //    if (this.txt_Conservacion_TempMaxima.Text != "")
        //        db.AddInParameter(dbc, "TMax", DbType.Decimal, this.txt_Conservacion_TempMaxima.Text);
        //    else
        //        db.AddInParameter(dbc, "TMax", DbType.Decimal, DBNull.Value);

        //    db.AddInParameter(dbc, "Observacion", DbType.String, this.txt_Conservacion_Observacion.Text);
        //    db.AddInParameter(dbc, "idProducto", DbType.String, idProducto);
        //    db.AddInParameter(dbc, "LimiteCritico", DbType.Decimal, this.txt_limiteCritico.Text.Trim() == "" ? "0" : this.txt_limiteCritico.Text.Trim());
        //    db.AddInParameter(dbc, "Ingredientes", DbType.String, this.txt_Ingredientes.Text);


        //    if (this.cb_Valida_Temp.Checked == true)
        //        db.AddInParameter(dbc, "Valida_Temperatura", DbType.String, "SI");
        //    else
        //        db.AddInParameter(dbc, "Valida_Temperatura", DbType.String, "NO");

        //    if (this.cb_Valida_VidaUtil.Checked == true)
        //        db.AddInParameter(dbc, "Valida_VidaUtil", DbType.String, "SI");
        //    else
        //        db.AddInParameter(dbc, "Valida_VidaUtil", DbType.String, "NO");


        //    if (this.ddl_TipoProducto.SelectedItem.ToString() != "(Seleccionar)")
        //        db.AddInParameter(dbc, "TipoProducto", DbType.String, this.ddl_TipoProducto.SelectedItem.ToString());
        //    else
        //        db.AddInParameter(dbc, "TipoProducto", DbType.String, "");

        //    db.AddInParameter(dbc, "PuntoReapro", DbType.String, this.txt_PuntoReapro.Text);

        //    db.ExecuteNonQuery(dbc);


        //    //ACTIVIDAD
        //    Actividad.Crear(Page.User.Identity.Name.ToString(), Page.Request["id"].ToString(), "Modificación Producto"
        //                            , "idProducto: " + idProducto + " | Alimento: " + this.ddl_Alimento.SelectedValue
        //                            , "Vida Util: " + txt_Conservacion_VidaUtil.Text
        //                            , "TMIN: " + this.txt_Conservacion_TempMinima.Text + " - TMAX: " + this.txt_Conservacion_TempMaxima.Text);

        //    /* 
        //     * *****************PARA PRODUCCION*****************
        //     * 
        //    //Guardamos VidaUtil en SRT y SRT-A
        //    if (this.txt_Conservacion_VidaUtil.Text != "")
        //    {
        //        string varSQL = "SQL-SRT";

        //        if (this.lbl_idEntidad.Text == "1")
        //        {
        //            varSQL = "SQL-SRT-A";
        //        }

        //        Database db_1 = DatabaseFactory.CreateDatabase(varSQL);
        //        string sqlCommand_1 = "UPDATE Productos SET VidaUtil=@VidaUtil WHERE LITM=@LITM AND IdEntidad=@idEntidad AND eliminado=0";
        //        DbCommand dbc_1 = db_1.GetSqlStringCommand(sqlCommand_1);

        //        db_1.AddInParameter(dbc_1, "idEntidad", DbType.Int32, this.lbl_idEntidad.Text);
        //        db_1.AddInParameter(dbc_1, "LITM", DbType.String, this.txt_CodigoProducto.Text); //WRIN
        //        db_1.AddInParameter(dbc_1, "VidaUtil", DbType.String, this.txt_Conservacion_VidaUtil.Text);

        //        db_1.ExecuteNonQuery(dbc_1);
        //    }
        //    */



        //    Response.Redirect("Productos.aspx");
        //}

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idColor = int.Parse(Request.QueryString["id"]);
            NegocioColores.eliminar(idColor);

            Response.Redirect("Colores.aspx");
        }

        //protected void btn_Imagen_Editar_Click(object sender, CommandEventArgs e)
        //{
        //    Response.Redirect("Productos_imagen.aspx?img=" + e.CommandArgument + "&id=" + Request.QueryString["id"] + "&p=" + Request.QueryString["p"]);
        //}

        //protected void Cargar_Proveedores()
        //{
        //    Database db = DatabaseFactory.CreateDatabase("Sql");
        //    string sqlCommand = "SELECT a.id, b.AN8, b.ALPH  "
        //                       + " FROM Productos_Proveedores a "
        //                       + " INNER JOIN Proveedores b ON b.AN8 = a.AN8 AND b.IdEntidad=a.idEntidad "
        //                       + " WHERE a.idEntidad=@idEntidad  AND a.idCentro=@idCentro "
        //                       + "         AND a.LITM=@Wrin "
        //                       + "         AND b.eliminado=0 ";

        //    DbCommand dbc = db.GetSqlStringCommand(sqlCommand);

        //    db.AddInParameter(dbc, "Wrin", DbType.String, this.txt_CodigoProducto.Text); //WRIN
        //    db.AddInParameter(dbc, "idEntidad", DbType.String, lbl_idEntidad.Text);
        //    db.AddInParameter(dbc, "idCentro", DbType.String, lbl_idCentro.Text);

        //    DataSet ds = db.ExecuteDataSet(dbc);

        //    grid_Proveedores.DataSource = ds;
        //    grid_Proveedores.DataBind();
        //}

        //protected void Cargar_DDL_Proveedores()
        //{
        //    Database db = DatabaseFactory.CreateDatabase("Sql");
        //    string sqlCommand = "SELECT a.AN8, a.AN8 + ' - ' + a.ALPH as ALPH "
        //                       + " FROM Proveedores a "
        //                       + " LEFT JOIN Productos_Proveedores b ON b.AN8 = a.AN8 AND b.IdEntidad=a.idEntidad AND b.idCentro=@idCentro AND b.LITM=@Wrin  "
        //                       + " WHERE a.idEntidad=@idEntidad  AND a.eliminado=0 "
        //                       + "       AND b.id IS NULL ";

        //    DbCommand dbc = db.GetSqlStringCommand(sqlCommand);

        //    db.AddInParameter(dbc, "Wrin", DbType.String, this.txt_CodigoProducto.Text); //WRIN
        //    db.AddInParameter(dbc, "idEntidad", DbType.String, lbl_idEntidad.Text);
        //    db.AddInParameter(dbc, "idCentro", DbType.String, lbl_idCentro.Text);

        //    DataSet ds = db.ExecuteDataSet(dbc);

        //    ddl_Proveedores.DataSource = ds;
        //    ddl_Proveedores.DataValueField = "AN8";
        //    ddl_Proveedores.DataTextField = "ALPH";
        //    ddl_Proveedores.DataBind();

        //}

        //private void Cargar_Grilla_Imagenes()
        //{
        //    string id = Request.QueryString["id"];

        //    img_thumbnail.ImageUrl = Producto.CargarImagen(id);
        //}

        //protected void btn_Proveedores_Agregar_OnClick(object sender, EventArgs e)
        //{
        //    Database db = DatabaseFactory.CreateDatabase("Sql");
        //    DbCommand dbc = db.GetSqlStringCommand("INSERT INTO Productos_Proveedores (LITM, AN8, idEntidad, idCentro) VALUES (@LITM, @AN8, @idEntidad, @idCentro) ");

        //    db.AddInParameter(dbc, "LITM", DbType.String, this.txt_CodigoProducto.Text); //WRIN
        //    db.AddInParameter(dbc, "AN8", DbType.String, ddl_Proveedores.SelectedValue);
        //    db.AddInParameter(dbc, "idEntidad", DbType.String, lbl_idEntidad.Text);
        //    db.AddInParameter(dbc, "idCentro", DbType.String, lbl_idCentro.Text);

        //    db.ExecuteNonQuery(dbc);

        //    Cargar_DDL_Proveedores();

        //    Cargar_Proveedores();
        //}

        //protected void btn_Imagen_Agregar_OnClick(object sender, EventArgs e)
        //{
        //    if ((this.FileUpload1.PostedFile != null) && (this.FileUpload1.PostedFile.ContentLength > 0))
        //    {
        //        string extension = Path.GetExtension(FileUpload1.FileName);
        //        if (extension.ToLower() == ".png" || extension.ToLower() == ".jpg")
        //        {
        //            Stream strm = FileUpload1.PostedFile.InputStream;
        //            using (var image = System.Drawing.Image.FromStream(strm))
        //            {
        //                string id = Request.QueryString["id"];

        //                string path = Server.MapPath("~/upload/Productos/Producto_" + id + "/");


        //                if (!Directory.Exists(path))
        //                {
        //                    Directory.CreateDirectory(path);
        //                }


        //                // Print Original Size of file (Height or Width)   
        //                //Label1.Text = image.Size.ToString();
        //                int newWidth = 240; // New Width of Image in Pixel  
        //                int newHeight = 240; // New Height of Image in Pixel  
        //                var thumbImg = new Bitmap(newWidth, newHeight);
        //                var thumbGraph = Graphics.FromImage(thumbImg);
        //                thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
        //                thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
        //                thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //                var imgRectangle = new Rectangle(0, 0, newWidth, newHeight);
        //                thumbGraph.DrawImage(image, imgRectangle);
        //                // Save the file  

        //                string filename = path + FileUpload1.FileName;

        //                thumbImg.Save(filename, image.RawFormat);
        //            }
        //        }

        //        Cargar_Grilla_Imagenes();
        //    }
        //}

        //protected void btn_Proveedor_Quitar_OnClick(object sender, EventArgs e)
        //{
        //    string id = (sender as LinkButton).CommandArgument;

        //    Database db = DatabaseFactory.CreateDatabase("Sql");
        //    DbCommand dbc = db.GetSqlStringCommand("DELETE FROM Productos_Proveedores WHERE id=@id ");

        //    db.AddInParameter(dbc, "id", DbType.String, id);

        //    db.ExecuteNonQuery(dbc);

        //    Cargar_DDL_Proveedores();

        //    Cargar_Proveedores();
        //}

        //protected void btn_BorrarImagen_Click(object sender, EventArgs e)
        //{

        //    string id = Request.QueryString["id"];

        //    string path = "/upload/Productos/Producto_" + id + "/";
        //    string ServerPath = Server.MapPath(path);

        //    System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\inetpub\wwwroot\WMS\" + path);

        //    foreach (FileInfo file in di.GetFiles())
        //    {
        //        file.Delete();
        //    }


        //    Response.Redirect("Productos.aspx");
        //}
    }
}