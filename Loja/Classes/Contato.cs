using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Loja.Classes
{
    public partial class Contato
    {
        private bool _isNew;
        [Browsable(false)]
        public bool IsNew
        {
            get
            {
                return _isNew;
            }
        }

        private bool _isModified;
        [Browsable(false)]
        public bool IsModified
        {
            get
            {
                return _isModified;
            }
        }


        //public int Codigo { get; set; }

        private int _codigo;

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
                this._isModified = true;
            }
        }

        //public string DadosContato { get; set; }

        private string _dadosContato;

        public string DadosContato
        {
            get
            {
                return _dadosContato;
            }
            set
            {
                _dadosContato = value;
                this._isModified = true;
            }
        }

        //public string Tipo { get; set; }

        private string _tipo;

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
                this._isModified = true;
            }
        }

        private int _cliente;
        public int Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
            }
        }


    }
}
