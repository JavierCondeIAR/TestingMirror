using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestOperaciones {

    [Test] //Tipo de prueba que no necesita  estar en tiempo de ejecución.
    //Los TestCase se utilizan para realizar la misma prueba con diferentes parámetros sin repetir código.
    [TestCase(1, 2, 3)] //En cada uno de los TestCase se pasan los diferentes parámetros para las pruebas.
    [TestCase(5, 5, 10)]
    [TestCase(5, 5, 8)]
    public void SumaTestMethod(int param1, int param2, int result) { //Los tipos de estos parámetros tienen que ser del mismo tipo que los de los TestCase.
        double resultado = Aritmetica.sumar(param1, param2);

        //Cada Assert corresponde una comprobación necesaria para pasar la prueba.
        Assert.AreEqual(result, resultado);
        //Assert.That() --> Permite introducir una condición. Ej:
        Assert.That(result == resultado);
    }

    //[UnityTest] //Tipo de prueba en la que puedes controlar intervalos de tiempo en PlayMode
    //public IEnumerator MultiplicarTestMethod() {
    //    double resultado = Aritmetica.multiplicar(2, 2);
    //    Assert.AreEqual(4, resultado);

    //    yield return new WaitForSeconds(5);

    //    double resultado2 = Aritmetica.multiplicar(2, 2);
    //    Assert.AreEqual(4, resultado2);
    //}
    [Test] //Tipo de prueba en la que puedes controlar intervalos de tiempo en PlayMode
    public void MultiplicarTestMethod() {
        double resultado = Aritmetica.multiplicar(2, 2);
        Assert.AreEqual(8, resultado);


    }
}
