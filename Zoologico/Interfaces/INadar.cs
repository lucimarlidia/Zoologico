﻿namespace Zoologico.Interfaces;

public interface INadar
{
    int ProfundidadeMaxima { get; }
    void Nadar();
    void Descer();
    void Subir();
}
