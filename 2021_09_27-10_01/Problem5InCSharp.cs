using System;
using System.Collections.Generic;
public class Problem5InCSharp
{
	//counts the orders using math to get a very fast system
	public static long MathOrders(int[] countsByColor){
		long output= 1;
		int sizeOfList= 0;
		foreach(int count in countsByColor){
			output*= rCr(sizeOfList, count-1);//insert all but last one into list somewhere
			sizeOfList+= count;
		}
		return output;
	}
	public static long rCr(int r1, int r2){//like nCr but n= r1+r2; works because nCr(n, r)== nCr(n, n-r) 
		long outnum= 1;
		long outden= 1;
		for(; r2>0; r2--){
			outnum*= (r1+r2);
			outden*= r2;
		}
		return outnum/outden;
	}
	//counts orders by generating them each individually also prints each one to the console
	public static long ListOrders(int[] countsByColor){
		long counter= 0;
		ListOrders(countsByColor, ref counter);
		return counter;
	}
	private static void ListOrders(int[] countsByColor, ref long count, List<int> currentOrder= null, int color= 0, int currentColorI= 0, int placeIndex= 0){
		if(currentOrder == null)
			currentOrder= new List<int>();
		if(currentColorI == countsByColor[color] - 1){
			currentOrder.Add(color);
			if(color == countsByColor.Length - 1){
				count++;
				Console.WriteLine(count +":\t"+StringifyOrder(currentOrder));
			}else{
				ListOrders(countsByColor, ref count, currentOrder, color + 1);
			}
			currentOrder.RemoveAt(currentOrder.Count - 1);
		}else{
			for(; placeIndex <= currentOrder.Count; placeIndex ++){
				currentOrder.Insert(placeIndex, color);
				ListOrders(countsByColor, ref count, currentOrder, color, currentColorI + 1, placeIndex + 1);
				currentOrder.RemoveAt(placeIndex);
			}
		}
	}
	private static string StringifyOrder(List<int> order){
		string output= "";
		foreach(int i in order){
			output+= i + ",\t";
		}
		return output.Substring(0, output.Length -2);
	}
	
	//counts orders by generating a model representing them each individually
	public static long CountOrders(int[] countsByColor){
		long counter= 0;
		CountOrders(countsByColor, ref counter);
		return counter;
	}
	private static void CountOrders(int[] countsByColor, ref long count, int currentOrderLen= 0, int color= 0, int currentColorI= 0, int placeIndex= 0){
		if(currentColorI == countsByColor[color] - 1){
			if(color == countsByColor.Length - 1){
				count++;
			}else{
				CountOrders(countsByColor, ref count, currentOrderLen + 1, color + 1);
			}
		}else{
			for(; placeIndex <= currentOrderLen; placeIndex ++){
				CountOrders(countsByColor, ref count, currentOrderLen + 1, color, currentColorI + 1, placeIndex + 1);
			}
		}
	}
	public static void Main()
	{
		int[] test1= {1,1,1};
		Console.WriteLine(ListOrders(test1));
		Console.WriteLine(CountOrders(test1));
		Console.WriteLine(MathOrders(test1));
		
		int[] test2= {2,2,2};
		Console.WriteLine(ListOrders(test2));
		Console.WriteLine(CountOrders(test2));
		Console.WriteLine(MathOrders(test2));
		
		int[] test3= {4,3,2,1};
		Console.WriteLine(ListOrders(test3));
		Console.WriteLine(CountOrders(test3));
		Console.WriteLine(MathOrders(test3));
		
		
		int[] test4= {1,2};
		Console.WriteLine(ListOrders(test4));
		Console.WriteLine(CountOrders(test4));
		Console.WriteLine(MathOrders(test4));
		
		int[] test5= {2,2};
		Console.WriteLine(ListOrders(test5));
		Console.WriteLine(CountOrders(test5));
		Console.WriteLine(MathOrders(test5));
	}
	
}