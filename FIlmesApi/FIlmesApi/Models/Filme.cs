using System.ComponentModel.DataAnnotations;

namespace FIlmesApi.Models;

public class Filme
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [MaxLength(255, ErrorMessage ="Tamanho máximo de 255 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage ="O Genero do filme é obrigatório")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O tempo de duração é obrigatório")]
    [Range(70, 600, ErrorMessage ="O tamanho minino de um Longa é de 70 minutos")]
    public int Duracao { get; set; }

    
}
