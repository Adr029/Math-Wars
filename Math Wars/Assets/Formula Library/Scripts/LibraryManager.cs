using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
   [SerializeField]GameObject arithmetic;
   [SerializeField]GameObject algebra;
   [SerializeField]GameObject calculus;
   [SerializeField]GameObject close;
   [SerializeField]GameObject arithmeticButton;
   [SerializeField]GameObject algebraButton;
   [SerializeField]GameObject calculusButton;

   public void Arithmetic()
   {
    arithmetic.SetActive(true);
    algebra.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);
   }
   public void Algebra()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(true);
    calculus.SetActive(false);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);

   }
   public void Calculus()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(true);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);

   }

   public void CloseBook()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(false);
    arithmeticButton.SetActive(true);
    algebraButton.SetActive(true);
    calculusButton.SetActive(true);
   }
}
