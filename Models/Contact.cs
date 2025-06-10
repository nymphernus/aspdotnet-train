using System;
using System.ComponentModel.DataAnnotations;

namespace aspdotnet_train.Models;

public class Contact
{
    [Display(Name = "Введите имя")]
    [Required(ErrorMessage = "Имя не указано")]
    public string Name { get; set; }

    [Display(Name = "Введите фамилию")]
    [Required(ErrorMessage = "Фамилия не указана")]
    public string Surname { get; set; }

    [Display(Name = "Введите возраст")]
    [Required(ErrorMessage = "Возраст не указан")]
    public int Age { get; set; }

    [Display(Name = "Введите почту")]
    [Required(ErrorMessage = "Почта не указана")]
    public string Email { get; set; }

    [Display(Name = "Введите сообщение")]
    [Required(ErrorMessage = "Сообщение не введено")]
    [StringLength(30, ErrorMessage = "Текст не менее 30 символов")]
    public string Message { get; set; }
}
