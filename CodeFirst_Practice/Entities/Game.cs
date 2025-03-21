﻿using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Practice.Entities;

public class Game
{


    public int Id { get; set; }

    public string Name { get; set; }

    public string Platform { get; set; }

    
    public double Rating { get; set; }


}
