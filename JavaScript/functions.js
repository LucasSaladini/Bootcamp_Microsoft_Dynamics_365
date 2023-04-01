function calculateBmi(weightInKg, heightInMeters) {
    return weightInKg / Math.pow(heightInMeters, 2)
}

function classifyBmi(bmi) {
    if (bmi < 18.5) {
        return 'Abaixo do peso'
    } else if (bmi >=18.5 && bmi < 25) {
        return 'Peso normal'
    } else if (bmi >= 25 && bmi < 30) {
        'Acima do peso'
    } else if (bmi >= 30 && bmi < 40) {
        return 'Obeso'
    } else {
        return 'Obesidade grave'
    }
}

(function main() {
    const heightInMeters = 1.75
    const weightInKg = 75
    
    const bmi = calculateBmi(weightInKg, heightInMeters)
    console.log(classifyBmi(bmi))
})()
