﻿using System.Text;
using System.Text.RegularExpressions;

namespace Fernandez.Julian._2C
{
    public abstract class Vehiculo
    {

        #region Atributos
        public enum EVehiculos { Automovil, Moto }
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        #endregion

        #region Propiedades
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }
        public DateTime HoraEgreso
        {
            get => this.horaEgreso;
            set { if (value > horaIngreso) this.horaEgreso = value; }
        }
        public DateTime HoraIngreso { get => this.horaIngreso; set => this.horaIngreso = value; }
        public string Patente
        {
            get => this.patente;
            set
            {
                if (this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        #endregion

        #region Constructor
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.HoraIngreso = horaIngreso;
        }
        #endregion

        #region Metodos
        protected virtual double CargoDeEstacionamiento()
        {
            return (this.horaEgreso - this.horaIngreso).Hours;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nPatente: {this.Patente}");
            sb.Append($"\nHora de ingreso: {this.HoraIngreso}");

            return $"{sb}";
        }
        #endregion

        #region Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        private bool ValidarPatente(string patente)
        {
            return Regex.IsMatch(patente, @"^[a-zA-Z]{6,7}$");
        }
        #endregion
    }
}