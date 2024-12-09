using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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

        public string GetStatusName()
        {
            var memberInfo = Status.GetType().GetMember(Status.ToString());
            var attribute = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name ?? Status.ToString();
        }

        public static string GetStatusName(DeliveryStatus status)
        {
            var memberInfo = status.GetType().GetMember(status.ToString());
            var attribute = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name ?? status.ToString();
        }
    }

public enum DeliveryStatus
    {
        // Etapa 1: Antes do envio
        [Display(Name = "Criado")]
        Criado = 1,             // O pacote foi registrado no sistema.

        // Etapa 2: Durante o transporte
        [Display(Name = "Coletado")]
        Coletado = 2,           // Pacote foi coletado pelo transportador.

        [Display(Name = "Em Trânsito")]
        EmTransito = 3,         // Pacote está em transporte para o próximo destino.

        [Display(Name = "Transferido")]
        Transferido = 4,        // Pacote foi transferido para outro transportador ou unidade.

        // Etapa 3: Próximo da entrega
        [Display(Name = "Saiu para Entrega")]
        SaiuParaEntrega = 5,    // Pacote está com o entregador para entrega final.

        [Display(Name = "Tentativa de Entrega")]
        TentativaDeEntrega = 6, // Tentativa de entrega foi realizada, mas não concluída.

        [Display(Name = "Reagendado para Entrega")]
        ReagendadoParaEntrega = 7, // Entrega foi reagendada.

        // Etapa 4: Finais
        [Display(Name = "Entregue")]
        Entregue = 8,           // Pacote foi entregue com sucesso.

        [Display(Name = "Não Entregue")]
        NaoEntregue = 9,        // Não foi possível entregar o pacote após várias tentativas.

        [Display(Name = "Devolvido ao Remetente")]
        DevolvidoAoRemetente = 10, // Pacote foi devolvido ao remetente.

        [Display(Name = "Cancelado")]
        Cancelado = 11,          // Envio foi cancelado.

        [Display(Name = "Extraviado")]
        Extraviado = 12,         // Pacote foi perdido durante o transporte.
    }
}
