@import url(/styles/header.css);
@import url(/styles/banner.css);
@import url(/styles/carrossel.css);
@import url(/styles/topicos.css);
@import url(/styles/contato.css);
@import url(/styles/rodape.css);

:root{
    --cor-de-fundo: #EBECEE;
    --cor-principal:#262597;
    --branco:#FFFFFF;
    --preto: #000000;
    --roxo: #9949B4;
    --amarelo: #F1F10E;
    --azul: #3d89ec;
    --azul-degrade: linear-gradient(#262597,#16CFF8);;
    --fonte-principal: "Roboto";
    --fonte-secundaria: "Prompt";
}

body {
    background-color: var(--cor-de-fundo);
    font-family: var(--fonte-principal);
}

h1 {
    color: var(--branco);
}

.secao1 {
    background-image: linear-gradient(#424E61,#16CFF8);
    color: white;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 24px 0;
}

.secao1-titulo {
    padding: 24px 0;
}

.secao1-imagem {
    width: 40%;
}

.secao1-div-conteudo{
    width: 35%;
}

.nome-img {
    width: 200px;
}

.div-apresentacao{
    text-align: center;
    padding: 16px 0;
}

.apresentacao-titulo{
    text-align: center;
    font-family: var(--fonte-principal);
    font-weight: 400;
    font-size: 24px;
}

.icones{
    display: flex;
    justify-content: center;
}

.icon-redes{
    width: 24px;
    padding: 4px 20px;
}

.section3-img-1{
    width: 40%;
}