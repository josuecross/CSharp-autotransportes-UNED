using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Servidor.src
{
    public static class Herramientas
    {
        //Validar datos numericos por si se encuentran excepciones de los textBox en formularios windows

        public static bool validarDatoNumerico(ref int _valor, TextBox _textboxAValidar)
        {
            _textboxAValidar.BackColor = Color.White;
            try
            {
                _valor = int.Parse(_textboxAValidar.Text);
                if (_valor > 0)
                {

                    return true;
                }
                else
                {
                    _textboxAValidar.BackColor = Color.LightSalmon;
                    return false;
                }

            }
            catch (Exception ex)
            {
                _textboxAValidar.BackColor = Color.LightSalmon;
                return false;
            }
        }
        public static bool validarDatoNumerico(ref double _valor, TextBox _textboxAValidar)
        {
            _textboxAValidar.BackColor = Color.White;
            try
            {
                _valor = int.Parse(_textboxAValidar.Text);
                if (_valor > 0)
                {
                    return true;
                }
                else
                {
                    _textboxAValidar.BackColor = Color.LightSalmon;
                    return false;
                }

            }
            catch (Exception ex)
            {
                _textboxAValidar.BackColor = Color.LightSalmon;
                return false;
            }
        }
    }
}
