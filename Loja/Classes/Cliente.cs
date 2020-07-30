using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Loja.Classes
{
    public partial class Cliente
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
        [DisplayName("Código")]
        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (value < 0)
                {
                    throw new Loja.Excecoes.ValidacaoException("O código do cliente não pode ser negativo.");
                    _codigo = 0;
                }
                _codigo = value;
                this._isModified = true;
            }
        }

        //public string Nome { get; set; }
        private string _nome;
        [DisplayName("Nome do Cliente")]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {/*
              Alterei a condição de '<= 3' para '< 0' pq na hora de adicionar um novo Cliente no Form, assim que eu digitava
              a primeira letra o programa já parava, pois como ele atualiza instantaneamente, assim que eu digitava o 1º
                carctere a validação de exceções entendia como definitivo aquele caractere e parava de rodar.
              */
                if (value.Length < 0)
                {
                    throw new Loja.Excecoes.ValidacaoException("O nome deve possuir mais de 3 caracteres.");
                    _nome = null;
                }
                _nome = value;
                this._isModified = true;
            }
        }

        //public int? Tipo { get; set; }
        private int _tipo;

        public int Tipo
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

        //public DateTime? DataCadastro { get; set; }
        private DateTime _dataCadastro;

        public DateTime DataCadastro
        {
            get
            {
                return _dataCadastro;
            }
            set
            {
                _dataCadastro = value;
                this._isModified = true;
            }
        }


        //public List<Contato> Contato { get; set; }
        private List<Contato> _contato;

        public List<Contato> Contato
        {
            get
            {
                return _contato;
            }
            set
            {
                _contato = value;
            }
        }




    }
}
