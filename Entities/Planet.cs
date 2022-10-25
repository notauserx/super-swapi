﻿namespace Entities;

public class Planet
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Diameter { get; set; }

    public string RotationPeriod { get; set; }

    public string OrbitalPeriod { get; set; }

    public string Gravity { get; set; }

    public string Climate { get; set; }

    public string Terrain { get; set; }

    public string SurfaceWater { get; set; }

    public ICollection<People> Residents { get; set; }

    public ICollection<Film> Films { get; set; }

}