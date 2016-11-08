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
            Server.Transfer("~/Seguridad/wf_Ingreso.aspx");
        }

        private bool ValidarUsuario(string strUsuario, string strClave)
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
                    return false;
                }
                else
                {
                    //caso donde el login sea de exito
                    //res[0] Perfil
                    //res[1] Nombre
                    //res[2] Area
                    // 
                   // return true;
                }

                //buscar el usuario con strusuario en la tabla funcionarios.
            }
            catch (Exception)
            {
                return false;
            }
            return false;

        }
    }


}