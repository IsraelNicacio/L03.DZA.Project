
<div align="center">
  <img height="150" src="./src/Assets/Logo_IDN_DEV_Sem_Fundo.png"  />
</div>


# Titulo do Projeto

Uma breve descrição sobre o que esse projeto faz e para quem le


## Documentacao da API

#### Retorna todos os itens

```http
  GET /api/items
```

| Parâmetro   | Tipo       | Obrigatório | Descrição                          |
| :---------- | :--------- | :--------- |:---------------------------------- |
| `api_key` | `string` | **Sim** | A chave da sua API |

#### Retorna um item

```http
  GET /api/items/${id}
```

| Parâmetro   | Tipo       | Descrição                                  |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. O ID do item que você quer |

#### add(num1, num2)

Recebe dois n�meros e retorna a sua soma.


## Apêndice

Coloque qualquer informação adicional aqui


## Stack utilizada

<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg" height="40" alt="github logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-original.svg" height="40" alt="docker logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain-wordmark.svg" height="40" alt="microsoftsqlserver logo"  />
</div>


## Etiquetas

Adicione etiquetas de algum lugar, como: [shields.io](https://shields.io/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)


## Deploy

Para fazer o deploy desse projeto rode

```bash
  npm run deploy
```

