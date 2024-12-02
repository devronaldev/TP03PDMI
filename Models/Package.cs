using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03PDMI.Models
{
    public class Package
    {
        [Required]
        [DisplayName("Código")]
        public string PackageId { get; set; }

        public DeliveryStatus Status {  get; set; }

        [DisplayName("Enviado em: ")]
        public DateTime SentAt { get; set; }

        [DisplayName("Previsão de entrega: ")]
        public DateTime EstimatedDeliveryDate { get; set; }

        [DisplayName("Localização: ")]
        public string Locate {  get; set; }

        public List<Event> Events {  get; set; } 
    }

    public enum DeliveryStatus
    {
        // Etapa 1: Antes do envio
        Criado = 1,             // O pacote foi registrado no sistema.
        
        // Etapa 2: Durante o transporte
        Coletado = 2,           // Pacote foi coletado pelo transportador.
        EmTransito = 3,         // Pacote está em transporte para o próximo destino.
        Transferido = 4,        // Pacote foi transferido para outro transportador ou unidade.

        // Etapa 3: Próximo da entrega
        SaiuParaEntrega = 5,    // Pacote está com o entregador para entrega final.
        TentativaDeEntrega = 6,// Tentativa de entrega foi realizada, mas não concluída.
        ReagendadoParaEntrega = 7, // Entrega foi reagendada.

        // Etapa 4: Finais
        Entregue = 8,          // Pacote foi entregue com sucesso.
        NaoEntregue = 9,       // Não foi possível entregar o pacote após várias tentativas.
        DevolvidoAoRemetente = 10, // Pacote foi devolvido ao remetente.
        Cancelado = 11,         // Envio foi cancelado.
        Extraviado = 12,        // Pacote foi perdido durante o transporte.
    }
}
