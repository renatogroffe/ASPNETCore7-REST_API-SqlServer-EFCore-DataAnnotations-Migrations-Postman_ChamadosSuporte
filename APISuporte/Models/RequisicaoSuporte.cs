using System.ComponentModel.DataAnnotations;

namespace APISuporte.Models;

public class RequisicaoSuporte
{
    [Required(ErrorMessage = "Preencha o campo 'Email'")]
    [EmailAddress(ErrorMessage = "Formato inv�lido para o campo 'Email'")]
    [StringLength(100, ErrorMessage = "O campo 'Email' deve possuir no m�ximo 100 caracteres")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Preencha o campo 'DescritivoRequisicao'")]
    [MinLength(15, ErrorMessage = "O campo 'DescritivoRequisicao' deve possuir no m�nimo 15 caracteres")]
    [StringLength(500, ErrorMessage = "O campo 'DescritivoRequisicao' deve possuir no m�ximo 500 caracteres")]
    public string? DescritivoRequisicao { get; set; }
}