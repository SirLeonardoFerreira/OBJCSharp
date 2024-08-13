namespace Atividade {
    
    class Clientes{
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; set;}
        public float valor_imposto {get; set;}
        public float total {get; set;}

        public virtual void Pagar_imposto (float v){
            this.valor = v;
            this.valor_imposto = this.valor  * 10/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}