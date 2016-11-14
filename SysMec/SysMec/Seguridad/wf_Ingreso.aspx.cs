using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysMec.Seguridad
{
    public partial class wf_Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtClave.Text,txtClave.Text);
        }

        private void ValidarUsuario(string strUsuario, string strClave)
        {
            String strNombreUsrEnc = strUsuario;
            String strPassUsrEnc = strClave;
            String PathSistema = "MAG Costa Rica|Usuarios|Especiales|Usuarios Sistemas|SistemaCitasMedicas";
            Boolean boolConsiderarDominios = false;
            ws_AutenticacionWeb.AutenticacionUsuariosMAG login = new ws_AutenticacionWeb.AutenticacionUsuariosMAG();

            try
            {
                String[] res = login.LoguerUsuario(strNombreUsrEnc, strPassUsrEnc, PathSistema, boolConsiderarDominios);
                if (res[1] == null)
                {
                    //Comentar esta linea para ingresar sin contraseña (en sistema antiguo de mag, no necesariente sirve en SysMec)
                    strUsuario = null;
                    txtUsuario.Text = String.Empty;
                    txtClave.Text = String.Empty;
                    MsgBox("Datos incorrectos.", this.Page, this);
                    return;
                }
                else
                {
                    //caso donde el login sea de exito
                    //res[0] Perfil
                    //res[1] Nombre
                    //res[2] Area
                    // 
                    // return true;
                    MsgBox("Bienvenido(a).", this.Page, this);
                }

                //buscar el usuario con strusuario en la tabla funcionarios.
            }
            catch (Exception)
            {
                MsgBox("Verifique los datos ingresados.", this.Page, this);
                return;
            }
            return;

        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}