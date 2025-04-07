﻿using DZA.Core.DomainObject;

namespace DZA.Cadastro.Domain.Entities;

public class Departamento : EntityBase
{
    public string Nome { get; private set; }
    public ICollection<Pessoa> Pessoas { get; set; }

    public Departamento()
    { }

    public Departamento(string nome)
    {
        Nome = nome;
        Validacoes();
    }

    public void AlterarNome(string nome)
    {
        ValidationDomain.ValidarCaracteres(nome, 60, "O campo nome deve te no maximo 60 caracteres");
        Nome = nome;
    }

    public void Validacoes()
    {
        ValidationDomain.ValidarCaracteres(Nome, 60, "O campo nome deve te no maximo 60 caracteres");
    }
}
