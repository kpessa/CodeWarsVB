Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace CodeWarsVB
    <TestClass>
    Public Class KataTest
        <TestMethod>
        Public Sub isDivisibleTests()
            Assert.AreEqual(False, Kata.IsDivisible(3, 3, 4))
            Assert.AreEqual(True, Kata.IsDivisible(12, 3, 4))
            Assert.AreEqual(False, Kata.IsDivisible(8, 3, 4))
            Assert.AreEqual(True, Kata.IsDivisible(48, 3, 4))
            Assert.AreEqual(True, Kata.IsDivisible(100, 5, 10))
            Assert.AreEqual(False, Kata.IsDivisible(100, 5, 3))
            Assert.AreEqual(True, Kata.IsDivisible(4, 4, 2))
            Assert.AreEqual(False, Kata.IsDivisible(5, 2, 3))
            Assert.AreEqual(True, Kata.IsDivisible(17, 17, 17))
            Assert.AreEqual(True, Kata.IsDivisible(17, 1, 17))
        End Sub
    End Class
End Namespace

