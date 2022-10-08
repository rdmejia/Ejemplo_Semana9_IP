using System;
using System.Collections.Generic;
using System.Text;

namespace L9_RDMA_25873
{
    class Automovil
    {
        public int modelo;
        public double precio;
        public String marca;
        public bool disponible;
        public double tipoDeCambioDolar;
        public double descuentoAplicado;

        public Automovil(int modelo, double precio, String marca, bool disponible, double tipoDeCambioDolar)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.marca = marca;
            this.disponible = disponible;
            this.tipoDeCambioDolar = tipoDeCambioDolar;
            this.descuentoAplicado = 0.0;
        }

        public double ObtenerPrecio()
        {
            return this.precio * (1.0 - this.descuentoAplicado);
        }

        public double ObtenerPrecioEnDolares()
        {
            return this.ObtenerPrecio() / this.tipoDeCambioDolar;
        }
    }
}
