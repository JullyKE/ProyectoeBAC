using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EjerciciosEstructuras2 : MonoBehaviour
{
	int size = 4;
	int rangoI = 2;
	int rangoS = 5;
	List<int> miLista = new List<int>();
	
	int[] miArreglo1 = {1,3,4,2};
	int[] miArreglo2;
	
	List<int> listaRepetida = new List<int>();
	HashSet<int> miHashSet = new HashSet<int>();
	
	Stack<string> miPila = new Stack<string>();
    
	void Start()
	{
		//Ejercicio 1
		miLista = Ejercicio1(size,rangoI,rangoS);
		foreach (var numero in miLista)
		{
			Debug.Log("<color=red>Ejercicio1 Lista: </color>" + numero);
		}
		
		//Ejercicio 2
		foreach (var numero in miArreglo1)
		{
			Debug.Log("<color=green>Ejercicio2 Arreglo: </color>" + numero);
		}
		miArreglo2 = Ejercicio2(miArreglo1);
		foreach (var numero in miArreglo2)
		{
			Debug.Log("<color=green>Ejercicio2 ArregloOrdenado: </color>" + numero);
		}
		
		//Ejercicio 3
		for (int i = 0; i < 5; i++) 
		{
			listaRepetida.Add(Random.Range(1,3));
		}
		foreach (var numero in listaRepetida)
		{
			Debug.Log("<color=blue>Ejercicio3 Lista: </color>" + numero);
		}
		miHashSet = Ejercicio3(listaRepetida);
		foreach (var numero in miHashSet)
		{
			Debug.Log("<color=blue>Ejercicio3 HashSet: </color>" + numero);
		}
		
		//Ejercicio 4
		miPila.Push("Escuela");
		miPila.Push("Britanica");
		miPila.Push("de");
		miPila.Push("Artes");
		miPila.Push("Crativas");
		miPila.Push("y");
		miPila.Push("Tecnologicas");
		Ejercicio4(miPila);
		
	}
	
	public List<int> Ejercicio1(int size, int rInferior, int rSuperior)
	{
		for (int i = 0; i < size; i++) 
		{
			miLista.Add(Random.Range(rInferior,rSuperior));
		}	
		return miLista;
	}
	
	public int[] Ejercicio2(int[] arreglo)
	{
		arreglo = arreglo.OrderByDescending(c => c).ToArray();
		return arreglo;
	}
	
	public HashSet<int> Ejercicio3(List<int> numeros)
	{
		miHashSet = new HashSet<int>(numeros);
		return miHashSet;
	}
	
	public void Ejercicio4(Stack<string> pila)
	{
		Queue<string> cola = new Queue<string>();
		int total = pila.Count;
		for (int i = 0; i < total; i++)
		{
			Debug.Log("<color=purple>Ejercicio4 pila: </color>" + pila.Peek());
			foreach (var palabra in pila)
			{
				cola.Enqueue(palabra);	
			}
			pila.Pop();
		}
		
		for (int i = 0; i < total; i++)
		{
			Debug.Log("<color=purple>Ejercicio4 cola: </color>" + cola.Peek());
			cola.Dequeue();
		}
	}
}
