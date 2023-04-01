const precoEtanol = 5.79
const precoGasolina = 6.50
const consumoEmLitros = 14
const distanciaKm = 100
const tipoCombustivel = 'etanol'

const consumoViagem = (distanciaKm / consumoEmLitros)

if (tipoCombustivel === 'etanol') {
    let valorGasto = (consumoViagem * precoEtanol).toFixed(2)
    console.log(valorGasto)
} else {
    valorGasto = (consumoViagem * precoGasolina).toFixed(2)
    console.log(valorGasto)
}