﻿namespace LibraryManagement.Models.Dtos.Authors;

public class AuthorAddRequestDto
{
    public string FirstName { get; set; }

    public string SurName { get; set; }

    public int BirthDay { get; set; }

    public int BirthMonth { get; set; }

    public int BirthYear { get; set; }

}
