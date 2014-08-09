﻿// Seven
// https://github.com/53V3N1X/SevenFramework
// LISCENSE: See "LISCENSE.md" in th root project directory.
// SUPPORT: See "SUPPORT.md" in the root project directory.

namespace Seven.Mathematics
{
	/// <summary>Supplies linear algebra mathematics for generic types.</summary>
	/// <typeparam name="T">The type this linear algebra library can perform on.</typeparam>
	public interface LinearAlgebra<T>
  {
    #region vector

    /// <summary>Adds two vectors together.</summary>
    LinearAlgebra.delegates.Vector_Add<T> Vector_Add { get; }
    /// <summary>Negates all the values in a vector.</summary>
    LinearAlgebra.delegates.Vector_Negate<T> Vector_Negate { get; }
    /// <summary>Subtracts two vectors.</summary>
    LinearAlgebra.delegates.Vector_Subtract<T> Vector_Subtract { get; }
    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    LinearAlgebra.delegates.Vector_Multiply<T> Vector_Multiply { get; }
    /// <summary>Divides all the components of a vector by a scalar.</summary>
    LinearAlgebra.delegates.Vector_Divide<T> Vector_Divide { get; }
    /// <summary>Computes the dot product between two vectors.</summary>
    LinearAlgebra.delegates.Vector_DotProduct<T> Vector_DotProduct { get; }
    /// <summary>Computes teh cross product of two vectors.</summary>
    LinearAlgebra.delegates.Vector_CrossProduct<T> Vector_CrossProduct { get; }
    /// <summary>Normalizes a vector.</summary>
    LinearAlgebra.delegates.Vector_Normalize<T> Vector_Normalize { get; }
    /// <summary>Computes the length of a vector.</summary>
    LinearAlgebra.delegates.Vector_Magnitude<T> Vector_Magnitude { get; }
    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    LinearAlgebra.delegates.Vector_MagnitudeSquared<T> Vector_MagnitudeSquared { get; }
    /// <summary>Computes the angle between two vectors.</summary>
    LinearAlgebra.delegates.Vector_Angle<T> Vector_Angle { get; }
    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    LinearAlgebra.delegates.Vector_RotateBy<T> Vector_RotateBy { get; }
    /// <summary>Computes the linear interpolation between two vectors.</summary>
    LinearAlgebra.delegates.Vector_Lerp<T> Vector_Lerp { get; }
    /// <summary>Sphereically interpolates between two vectors.</summary>
    LinearAlgebra.delegates.Vector_Slerp<T> Vector_Slerp { get; }
    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    LinearAlgebra.delegates.Vector_Blerp<T> Vector_Blerp { get; }
    /// <summary>Checks for equality between two vectors.</summary>
    LinearAlgebra.delegates.Vector_EqualsValue<T> Vector_EqualsValue { get; }
    /// <summary>Checks for equality between two vectors with a leniency.</summary>
    LinearAlgebra.delegates.Vector_EqualsValue_leniency<T> Vector_EqualsValue_leniency { get; }
    /// <summary>Rotates a vector by a quaternion.</summary>
    LinearAlgebra.delegates.Vector_RotateBy_quaternion<T> Vector_RotateBy_quaternion { get; }

    #endregion

    #region matrix

    /// <summary>Negates all the values in this matrix.</summary>
    LinearAlgebra.delegates.Matrix_Negate<T> Matrix_Negate { get; }
		/// <summary>Does a standard matrix addition.</summary>
    LinearAlgebra.delegates.Matrix_Add<T> Matrix_Add { get; }
    /// <summary>Does a standard matrix subtraction.</summary>
    LinearAlgebra.delegates.Matrix_Subtract<T> Matrix_Subtract { get; }
		/// <summary>Does a standard matrix multiplication (triple for loop).</summary>
    LinearAlgebra.delegates.Matrix_Multiply<T> Matrix_Multiply { get; }
		/// <summary>Multiplies all the values in this matrix by a scalar.</summary>
    LinearAlgebra.delegates.Matrix_Multiply_scalar<T> Matrix_Multiply_scalar { get; }
    /// <summary>Premultiplies a vector by a matrix.</summary>
    LinearAlgebra.delegates.Matrix_Multiply_vector<T> Matrix_Multiply_vector { get; }
		/// <summary>Divides all the values in this matrix by a scalar.</summary>
    LinearAlgebra.delegates.Matrix_Divide<T> Matrix_Divide { get; }
    /// <summary>Takes the matrix to the given int power.</summary>
    LinearAlgebra.delegates.Matrix_Power<T> Matrix_Power { get; }
		/// <summary>Gets the minor of a matrix.</summary>
    LinearAlgebra.delegates.Matrix_Minor<T> Matrix_Minor { get; }
		/// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    LinearAlgebra.delegates.Matrix_ConcatenateRowWise<T> Matrix_ConcatenateRowWise { get; }
		/// <summary>Computes the determinent if this matrix is square.</summary>
    LinearAlgebra.delegates.Matrix_Determinent<T> Matrix_Determinent { get; }
		/// <summary>Computes the echelon form of this matrix (aka REF).</summary>
    LinearAlgebra.delegates.Matrix_Echelon<T> Matrix_Echelon { get; }
		/// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
    LinearAlgebra.delegates.Matrix_ReducedEchelon<T> Matrix_ReducedEchelon { get; }
		/// <summary>Computes the inverse of this matrix.</summary>
    LinearAlgebra.delegates.Matrix_Inverse<T> Matrix_Inverse { get; }
		/// <summary>Gets the adjoint of this matrix.</summary>
    LinearAlgebra.delegates.Matrix_Adjoint<T> Matrix_Adjoint { get; }
		/// <summary>Transposes this matrix.</summary>
    LinearAlgebra.delegates.Matrix_Transpose<T> Matrix_Transpose { get; }
    /// <summary>Decomposes a matrix to lower/upper components.</summary>
    LinearAlgebra.delegates.Matrix_DecomposeLU<T> Matrix_DecomposeLU { get; }
    /// <summary>Dtermines equality but value.</summary>
    LinearAlgebra.delegates.Matrix_EqualsByValue<T> Matrix_EqualsByValue { get; }
    /// <summary>Determines equality by value with leniency.</summary>
    LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<T> Matrix_EqualsByValue_leniency { get; }

    #endregion

    #region quaternion

    /// <summary>Computes the magnitude of quaternion.</summary>
    LinearAlgebra.delegates.Quaternion_Magnitude<T> Quaternion_Magnitude { get; }
    /// <summary>Computes the magnitude of a quaternion, but doesn't square root it.</summary>
    LinearAlgebra.delegates.Quaternion_MagnitudeSquared<T> Quaternion_MagnitudeSquared { get; }
    /// <summary>Gets the conjugate of the quaternion.</summary>
    LinearAlgebra.delegates.Quaternion_Conjugate<T> Quaternion_Conjugate { get; }
    /// <summary>Adds two quaternions together.</summary>
    LinearAlgebra.delegates.Quaternion_Add<T> Quaternion_Add { get; }
    /// <summary>Subtracts two quaternions.</summary>
    LinearAlgebra.delegates.Quaternion_Subtract<T> Quaternion_Subtract { get; }
    /// <summary>Multiplies two quaternions together.</summary>
    LinearAlgebra.delegates.Quaternion_Multiply<T> Quaternion_Multiply { get; }
    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    LinearAlgebra.delegates.Quaternion_Multiply_scalar<T> Quaternion_Multiply_scalar { get; }
    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    LinearAlgebra.delegates.Quaternion_Multiply_Vector<T> Quaternion_Multiply_Vector { get; }
    /// <summary>Normalizes the quaternion.</summary>
    LinearAlgebra.delegates.Quaternion_Normalize<T> Quaternion_Normalize { get; }
    /// <summary>Inverts a quaternion.</summary>
    LinearAlgebra.delegates.Quaternion_Invert<T> Quaternion_Invert { get; }
    /// <summary>Lenearly interpolates between two quaternions.</summary>
    LinearAlgebra.delegates.Quaternion_Lerp<T> Quaternion_Lerp { get; }
    /// <summary>Sphereically interpolates between two quaternions.</summary>
    LinearAlgebra.delegates.Quaternion_Slerp<T> Quaternion_Slerp { get; }
    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    LinearAlgebra.delegates.Quaternion_Rotate<T> Quaternion_Rotate { get; }
    /// <summary>Does a value equality check.</summary>
    LinearAlgebra.delegates.Quaternion_EqualsValue<T> Quaternion_EqualsValue { get; }
    /// <summary>Does a value equality check with leniency.</summary>
    LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<T> Quaternion_EqualsValue_leniency { get; }

    #endregion
  }

  /// <summary>Makes and stores implementations of linear algebra.</summary>
	public static class LinearAlgebra
  {
    #region delegate

    /// <summary>Stores the delegates used for linear algebra.</summary>
    public static class delegates
    {

      #region vector

      /// <summary>Adds two vectors together.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first vector of the addition.</param>
      /// <param name="right">The second vector of the addiiton.</param>
      /// <returns>The result of the addiion.</returns>
      public delegate T[] Vector_Add<T>(T[] left, T[] right);
      /// <summary>Negates all the values in a vector.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to have its values negated.</param>
      /// <returns>The result of the negations.</returns>
      public delegate T[] Vector_Negate<T>(T[] vector);
      /// <summary>Subtracts two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The left vector of the subtraction.</param>
      /// <param name="right">The right vector of the subtraction.</param>
      /// <returns>The result of the vector subtracton.</returns>
      public delegate T[] Vector_Subtract<T>(T[] left, T[] right);
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The vector to have the components multiplied by.</param>
      /// <param name="right">The scalars to multiply the vector components by.</param>
      /// <returns>The result of the multiplications.</returns>
      public delegate T[] Vector_Multiply<T>(T[] left, T right);
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The vector to have the components divided by.</param>
      /// <param name="right">The scalar to divide the vector components by.</param>
      /// <returns>The resulting vector after teh divisions.</returns>
      public delegate T[] Vector_Divide<T>(T[] vector, T right);
      /// <summary>Computes the dot product between two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first vector of the dot product operation.</param>
      /// <param name="right">The second vector of the dot product operation.</param>
      /// <returns>The result of the dot product operation.</returns>
      public delegate T Vector_DotProduct<T>(T[] left, T[] right);
      /// <summary>Computes teh cross product of two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first vector of the cross product operation.</param>
      /// <param name="right">The second vector of the cross product operation.</param>
      /// <returns>The result of the cross product operation.</returns>
      public delegate T[] Vector_CrossProduct<T>(T[] left, T[] right);
      /// <summary>Normalizes a vector.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to normalize.</param>
      /// <returns>The result of the normalization.</returns>
      public delegate T[] Vector_Normalize<T>(T[] vector);
      /// <summary>Computes the length of a vector.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to calculate the length of.</param>
      /// <returns>The computed length of the vector.</returns>
      public delegate T Vector_Magnitude<T>(T[] vector);
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to compute the length squared of.</param>
      /// <returns>The computed length squared of the vector.</returns>
      public delegate T Vector_MagnitudeSquared<T>(T[] vector);
      /// <summary>Computes the angle between two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="first">The first vector to determine the angle between.</param>
      /// <param name="second">The second vector to determine the angle between.</param>
      /// <returns>The angle between the two vectors in radians.</returns>
      public delegate T Vector_Angle<T>(T[] first, T[] second);
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to rotate.</param>
      /// <param name="angle">The angle of the rotation.</param>
      /// <param name="x">The x component of the axis vector to rotate about.</param>
      /// <param name="y">The y component of the axis vector to rotate about.</param>
      /// <param name="z">The z component of the axis vector to rotate about.</param>
      /// <returns>The result of the rotation.</returns>
      public delegate T[] Vector_RotateBy<T>(T[] vector, T angle, T x, T y, T z);
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The starting vector of the interpolation.</param>
      /// <param name="right">The ending vector of the interpolation.</param>
      /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
      /// <returns>The result of the interpolation.</returns>
      public delegate T[] Vector_Lerp<T>(T[] left, T[] right, T blend);
      /// <summary>Sphereically interpolates between two vectors.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The starting vector of the interpolation.</param>
      /// <param name="right">The ending vector of the interpolation.</param>
      /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
      /// <returns>The result of the slerp operation.</returns>
      public delegate T[] Vector_Slerp<T>(T[] left, T[] right, T blend);
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="a">The first vector of the interpolation.</param>
      /// <param name="b">The second vector of the interpolation.</param>
      /// <param name="c">The thrid vector of the interpolation.</param>
      /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
      /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
      /// <returns>The resulting vector of the barycentric interpolation.</returns>
      public delegate T[] Vector_Blerp<T>(T[] a, T[] b, T[] c, T u, T v);
      /// <summary>Does a value equality check.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first vector to check for equality.</param>
      /// <param name="right">The second vector  to check for equality.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Vector_EqualsValue<T>(T[] left, T[] right);
      /// <summary>Does a value equality check with leniency.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first vector to check for equality.</param>
      /// <param name="right">The second vector to check for equality.</param>
      /// <param name="leniency">How much the values can vary but still be considered equal.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Vector_EqualsValue_leniency<T>(T[] left, T[] right, T leniency);
      /// <summary>Rotates a vector by a quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="vector">The vector to rotate.</param>
      /// <param name="rotation">The quaternion to rotate the 3-component vector by.</param>
      /// <returns>The result of the rotation.</returns>
      public delegate T[] Vector_RotateBy_quaternion<T>(T[] vector, Quaternion<T> rotation);

      #endregion

      #region matrix

      /// <summary>Determines if a matrix is symetric.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to determine symetry on.</param>
      /// <returns>True if the matrix is symetric; false if not.</returns>
      public delegate bool Matrix_IsSymetric<T>(T[,] matrix);
      /// <summary>Negates all the values in a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to have its values negated.</param>
      /// <returns>The resulting matrix after the negations.</returns>
      public delegate T[,] Matrix_Negate<T>(T[,] matrix);
      /// <summary>Does standard addition of two matrices.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The left matrix of the addition.</param>
      /// <param name="right">The right matrix of the addition.</param>
      /// <returns>The resulting matrix after the addition.</returns>
      public delegate T[,] Matrix_Add<T>(T[,] left, T[,] right);
      /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The matrix to have the values subtracted from.</param>
      /// <param name="right">The scalar to subtract from all the matrix values.</param>
      /// <returns>The resulting matrix after the subtractions.</returns>
      public delegate T[,] Matrix_Subtract<T>(T[,] left, T[,] right);
      /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The left matrix of the multiplication.</param>
      /// <param name="right">The right matrix of the multiplication.</param>
      /// <returns>The resulting matrix of the multiplication.</returns>
      public delegate T[,] Matrix_Multiply<T>(T[,] left, T[,] right);
      /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The left matrix of the multiplication.</param>
      /// <param name="right">The right matrix of the multiplication.</param>
      /// <returns>The resulting matrix of the multiplication.</returns>
      public delegate T[] Matrix_Multiply_vector<T>(T[,] matrix, T[] right);
      /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to have the values multiplied.</param>
      /// <param name="right">The scalar to multiply the values by.</param>
      /// <returns>The resulting matrix after the multiplications.</returns>
      public delegate T[,] Matrix_Multiply_scalar<T>(T[,] matrix, T right);
      /// <summary>Divides all the values in the matrix by a scalar.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The matrix to divide the values of.</param>
      /// <param name="right">The scalar to divide all the matrix values by.</param>
      /// <returns>The resulting matrix with the divided values.</returns>
      public delegate T[,] Matrix_Divide<T>(T[,] left, T right);
      /// <summary>Applies a power to a square matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to be powered by.</param>
      /// <param name="power">The power to apply to the matrix.</param>
      /// <returns>The resulting matrix of the power operation.</returns>
      public delegate T[,] Matrix_Power<T>(T[,] matrix, int power);
      /// <summary>Gets the minor of a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to get the minor of.</param>
      /// <param name="row">The restricted row to form the minor.</param>
      /// <param name="column">The restricted column to form the minor.</param>
      /// <returns>The minor of the matrix.</returns>
      public delegate T[,] Matrix_Minor<T>(T[,] matrix, int row, int column);
      /// <summary>Combines two matrices from left to right 
      /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The left matrix of the concatenation.</param>
      /// <param name="right">The right matrix of the concatenation.</param>
      /// <returns>The resulting matrix of the concatenation.</returns>
      public delegate T[,] Matrix_ConcatenateRowWise<T>(T[,] left, T[,] right);
      /// <summary>Calculates the determinent of a square matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to calculate the determinent of.</param>
      /// <returns>The determinent of the matrix.</returns>
      public delegate T Matrix_Determinent<T>(T[,] matrix);
      /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
      /// <returns>The echelon of the matrix (aka REF).</returns>
      public delegate T[,] Matrix_Echelon<T>(T[,] matrix);
      /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
      /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
      public delegate T[,] Matrix_ReducedEchelon<T>(T[,] matrix);
      /// <summary>Calculates the inverse of a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to calculate the inverse of.</param>
      /// <returns>The inverse of the matrix.</returns>
      public delegate T[,] Matrix_Inverse<T>(T[,] matrix);
      /// <summary>Calculates the adjoint of a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to calculate the adjoint of.</param>
      /// <returns>The adjoint of the matrix.</returns>
      public delegate T[,] Matrix_Adjoint<T>(T[,] matrix);
      /// <summary>Returns the transpose of a matrix.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to transpose.</param>
      /// <returns>The transpose of the matrix.</returns>
      public delegate T[,] Matrix_Transpose<T>(T[,] matrix);
      /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="matrix">The matrix to decompose.</param>
      /// <param name="lower">The computed lower triangular matrix.</param>
      /// <param name="upper">The computed upper triangular matrix.</param>
      public delegate void Matrix_DecomposeLU<T>(T[,] matrix, out T[,] lower, out T[,] upper);
      /// <summary>Does a value equality check.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first matrix to check for equality.</param>
      /// <param name="right">The second matrix to check for equality.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Matrix_EqualsByValue<T>(T[,] left, T[,] right);
      /// <summary>Does a value equality check with leniency.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first matrix to check for equality.</param>
      /// <param name="right">The second matrix to check for equality.</param>
      /// <param name="leniency">How much the values can vary but still be considered equal.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Matrix_EqualsByValue_leniency<T>(T[,] left, T[,] right, T leniency);

      #endregion

      #region quaternion

      /// <summary>Computes the length of quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="quaternion">The quaternion to compute the length of.</param>
      /// <returns>The length of the given quaternion.</returns>
      public delegate T Quaternion_Magnitude<T>(Quaternion<T> quaternion);
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="quaternion">The quaternion to compute the length squared of.</param>
      /// <returns>The squared length of the given quaternion.</returns>
      public delegate T Quaternion_MagnitudeSquared<T>(Quaternion<T> quaternion);
      /// <summary>Gets the conjugate of the quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="quaternion">The quaternion to conjugate.</param>
      /// <returns>The conjugate of teh given quaternion.</returns>
      public delegate Quaternion<T> Quaternion_Conjugate<T>(Quaternion<T> quaternion);
      /// <summary>Adds two quaternions together.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first quaternion of the addition.</param>
      /// <param name="right">The second quaternion of the addition.</param>
      /// <returns>The result of the addition.</returns>
      public delegate Quaternion<T> Quaternion_Add<T>(Quaternion<T> left, Quaternion<T> right);
      /// <summary>Subtracts two quaternions.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The left quaternion of the subtraction.</param>
      /// <param name="right">The right quaternion of the subtraction.</param>
      /// <returns>The resulting quaternion after the subtraction.</returns>
      public delegate Quaternion<T> Quaternion_Subtract<T>(Quaternion<T> left, Quaternion<T> right);
      /// <summary>Multiplies two quaternions together.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first quaternion of the multiplication.</param>
      /// <param name="right">The second quaternion of the multiplication.</param>
      /// <returns>The resulting quaternion after the multiplication.</returns>
      public delegate Quaternion<T> Quaternion_Multiply<T>(Quaternion<T> left, Quaternion<T> right);
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The quaternion of the multiplication.</param>
      /// <param name="right">The scalar of the multiplication.</param>
      /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
      public delegate Quaternion<T> Quaternion_Multiply_scalar<T>(Quaternion<T> left, T right);
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The quaternion to pre-multiply the vector by.</param>
      /// <param name="right">The vector to be multiplied.</param>
      /// <returns>The resulting quaternion of the multiplication.</returns>
      public delegate Quaternion<T> Quaternion_Multiply_Vector<T>(Quaternion<T> left, Vector<T> right);
      /// <summary>Normalizes the quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="quaternion">The quaternion to normalize.</param>
      /// <returns>The normalization of the given quaternion.</returns>
      public delegate Quaternion<T> Quaternion_Normalize<T>(Quaternion<T> quaternion);
      /// <summary>Inverts a quaternion.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="quaternion">The quaternion to find the inverse of.</param>
      /// <returns>The inverse of the given quaternion.</returns>
      public delegate Quaternion<T> Quaternion_Invert<T>(Quaternion<T> quaternion);
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The starting point of the interpolation.</param>
      /// <param name="right">The ending point of the interpolation.</param>
      /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
      /// <returns>The result of the interpolation.</returns>
      public delegate Quaternion<T> Quaternion_Lerp<T>(Quaternion<T> left, Quaternion<T> right, T blend);
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The starting point of the interpolation.</param>
      /// <param name="right">The ending point of the interpolation.</param>
      /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
      /// <returns>The result of the interpolation.</returns>
      public delegate Quaternion<T> Quaternion_Slerp<T>(Quaternion<T> left, Quaternion<T> right, T blend);
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="rotation">The quaternion to rotate the vector by.</param>
      /// <param name="vector">The vector to be rotated by.</param>
      /// <returns>The result of the rotation.</returns>
      public delegate Vector<T> Quaternion_Rotate<T>(Quaternion<T> rotation, Vector<T> vector);
      /// <summary>Does a value equality check.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first quaternion to check for equality.</param>
      /// <param name="right">The second quaternion  to check for equality.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Quaternion_EqualsValue<T>(Quaternion<T> left, Quaternion<T> right);
      /// <summary>Does a value equality check with leniency.</summary>
      /// <typeparam name="T">The numeric type of the operation.</typeparam>
      /// <param name="left">The first quaternion to check for equality.</param>
      /// <param name="right">The second quaternion to check for equality.</param>
      /// <param name="leniency">How much the values can vary but still be considered equal.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public delegate bool Quaternion_EqualsValue_leniency<T>(Quaternion<T> left, Quaternion<T> right, T leniency);

      #endregion

    }

    #endregion

    #region libraries

    private static Seven.Structures.Map<object, System.Type> _linearAlgebras =
			new Seven.Structures.Map_Linked<object, System.Type>(
				(System.Type left, System.Type right) => { return left == right; },
				(System.Type type) => { return type.GetHashCode(); })
				{
          // provided libraries
					{ typeof(int), LinearAlgebra.LinearAlgebra_int.Get },
					{ typeof(double), LinearAlgebra.LinearAlgebra_double.Get },
					{ typeof(float), LinearAlgebra.LinearAlgebra_float.Get },
					{ typeof(decimal), LinearAlgebra.LinearAlgebra_decimal.Get },
					{ typeof(long), LinearAlgebra.LinearAlgebra_long.Get },
          { typeof(Fraction64), LinearAlgebra.LinearAlgebra_Fraction64.Get },
          { typeof(Fraction128), LinearAlgebra.LinearAlgebra_Fraction128.Get },
				};

    /// <summary>Checks to see if a linear algebra implementaton exists for the given type.</summary>
    /// <typeparam name="T">The type to check for a linear algebra implementation.</typeparam>
    /// <returns>True is an implementation exists; false if not.</returns>
    public static bool Check<T>()
    {
      return _linearAlgebras.Contains(typeof(T));
    }

    /// <summary>Adds an implementation of linear algebra for a given type.</summary>
    /// <typeparam name="T">The type the linear algebra library operates on.</typeparam>
    /// <param name="linearAlgebra">The linear algebra library.</param>
    public static void Set<T>(LinearAlgebra<T> linearAlgebra)
    {
      _linearAlgebras[typeof(T)] = linearAlgebra;
    }

    /// <summary>Gets a linear algebra library for the given type.</summary>
    /// <typeparam name="T">The type to get a linear algebra library for.</typeparam>
    /// <returns>A linear algebra library for the given type.</returns>
		public static LinearAlgebra<T> Get<T>()
		{
      if (_linearAlgebras.Contains(typeof(T)))
        return (LinearAlgebra<T>)_linearAlgebras[typeof(T)];
      else
        return new LinearAlgebra_unsupported<T>();
		}

    #region provided

    private class LinearAlgebra_Fraction128 : LinearAlgebra<Fraction128>
    {
      #region construct-simpleton

      private LinearAlgebra_Fraction128() { _instance = this; }
      private static LinearAlgebra_Fraction128 _instance;
      private static LinearAlgebra_Fraction128 Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_Fraction128();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_Fraction128 Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<Fraction128> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<Fraction128> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<Fraction128> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<Fraction128> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<Fraction128> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<Fraction128> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<Fraction128> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<Fraction128> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<Fraction128> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<Fraction128> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<Fraction128> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<Fraction128> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<Fraction128> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<Fraction128> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<Fraction128> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<Fraction128> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<Fraction128> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<Fraction128> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<Fraction128> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<Fraction128> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<Fraction128> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<Fraction128> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<Fraction128> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<Fraction128> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<Fraction128> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<Fraction128> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<Fraction128> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<Fraction128> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<Fraction128> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<Fraction128> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<Fraction128> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<Fraction128> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<Fraction128> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<Fraction128> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<Fraction128> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<Fraction128> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<Fraction128> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<Fraction128> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<Fraction128> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<Fraction128> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<Fraction128> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<Fraction128> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<Fraction128> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<Fraction128> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<Fraction128> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<Fraction128> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<Fraction128> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<Fraction128> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<Fraction128> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<Fraction128> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<Fraction128> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<Fraction128> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_Fraction64 : LinearAlgebra<Fraction64>
    {
      #region construct-simpleton

      private LinearAlgebra_Fraction64() { _instance = this; }
      private static LinearAlgebra_Fraction64 _instance;
      private static LinearAlgebra_Fraction64 Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_Fraction64();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_Fraction64 Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<Fraction64> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<Fraction64> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<Fraction64> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<Fraction64> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<Fraction64> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<Fraction64> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<Fraction64> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<Fraction64> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<Fraction64> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<Fraction64> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<Fraction64> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<Fraction64> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<Fraction64> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<Fraction64> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<Fraction64> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<Fraction64> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<Fraction64> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<Fraction64> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<Fraction64> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<Fraction64> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<Fraction64> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<Fraction64> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<Fraction64> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<Fraction64> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<Fraction64> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<Fraction64> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<Fraction64> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<Fraction64> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<Fraction64> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<Fraction64> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<Fraction64> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<Fraction64> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<Fraction64> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<Fraction64> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<Fraction64> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<Fraction64> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<Fraction64> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<Fraction64> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<Fraction64> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<Fraction64> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<Fraction64> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<Fraction64> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<Fraction64> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<Fraction64> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<Fraction64> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<Fraction64> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<Fraction64> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<Fraction64> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<Fraction64> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<Fraction64> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<Fraction64> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<Fraction64> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_decimal : LinearAlgebra<decimal>
    {
      #region construct-simpleton

      private LinearAlgebra_decimal() { _instance = this; }
      private static LinearAlgebra_decimal _instance;
      private static LinearAlgebra_decimal Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_decimal();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_decimal Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<decimal> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<decimal> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<decimal> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<decimal> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<decimal> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<decimal> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<decimal> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<decimal> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<decimal> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<decimal> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<decimal> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<decimal> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<decimal> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<decimal> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<decimal> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<decimal> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<decimal> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<decimal> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<decimal> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<decimal> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<decimal> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<decimal> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<decimal> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<decimal> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<decimal> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<decimal> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<decimal> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<decimal> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<decimal> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<decimal> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<decimal> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<decimal> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<decimal> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<decimal> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<decimal> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<decimal> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<decimal> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<decimal> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<decimal> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<decimal> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<decimal> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<decimal> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<decimal> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<decimal> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<decimal> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<decimal> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<decimal> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<decimal> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<decimal> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<decimal> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<decimal> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<decimal> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_double : LinearAlgebra<double>
    {
      #region construct-simpleton

      private LinearAlgebra_double() { _instance = this; }
      private static LinearAlgebra_double _instance;
      private static LinearAlgebra_double Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_double();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_double Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<double> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<double> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<double> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<double> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<double> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<double> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<double> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<double> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<double> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<double> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<double> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<double> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<double> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<double> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<double> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<double> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<double> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<double> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matrix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<double> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<double> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<double> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<double> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<double> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<double> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<double> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<double> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<double> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<double> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<double> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<double> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<double> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<double> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<double> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<double> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<double> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<double> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<double> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<double> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<double> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<double> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<double> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<double> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<double> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<double> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<double> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<double> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<double> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<double> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<double> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<double> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<double> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<double> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_float : LinearAlgebra<float>
    {
      #region construct-simpleton

      private LinearAlgebra_float() { _instance = this; }
      private static LinearAlgebra_float _instance;
      private static LinearAlgebra_float Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_float();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_float Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<float> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<float> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<float> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<float> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<float> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<float> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<float> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<float> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<float> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<float> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<float> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<float> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<float> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<float> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<float> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<float> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<float> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<float> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matrix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<float> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<float> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<float> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<float> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<float> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<float> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<float> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<float> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<float> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<float> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<float> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<float> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<float> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<float> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<float> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<float> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<float> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<float> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<float> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<float> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<float> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<float> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<float> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<float> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<float> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<float> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<float> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<float> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<float> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<float> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<float> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<float> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<float> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<float> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_long : LinearAlgebra<long>
    {
      #region construct-simpleton

      private LinearAlgebra_long() { _instance = this; }
      private static LinearAlgebra_long _instance;
      private static LinearAlgebra_long Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_long();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_long Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<long> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<long> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<long> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<long> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<long> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<long> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<long> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<long> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<long> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<long> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<long> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<long> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<long> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<long> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<long> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<long> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<long> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<long> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matrix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<long> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<long> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<long> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<long> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<long> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<long> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<long> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<long> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<long> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<long> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<long> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<long> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<long> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<long> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<long> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<long> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<long> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<long> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<long> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<long> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<long> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<long> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<long> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<long> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<long> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<long> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<long> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<long> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<long> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<long> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<long> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<long> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<long> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<long> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    private class LinearAlgebra_int : LinearAlgebra<int>
    {
      #region construct-simpleton

      private LinearAlgebra_int() { _instance = this; }
      private static LinearAlgebra_int _instance;
      private static LinearAlgebra_int Instance
      {
        get
        {
          if (_instance == null)
            return _instance = new LinearAlgebra_int();
          else
            return _instance;
        }
      }

      /// <summary>Gets Arithmetic for "byte" types.</summary>
      public static LinearAlgebra_int Get { get { return Instance; } }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<int> Vector_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<int> Vector_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<int> Vector_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<int> Vector_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<int> Vector_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<int> Vector_DotProduct { get { return LinearAlgebra.DotProduct; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<int> Vector_CrossProduct { get { return LinearAlgebra.CrossProduct; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<int> Vector_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<int> Vector_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<int> Vector_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<int> Vector_Angle { get { return LinearAlgebra.Angle; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<int> Vector_RotateBy { get { return LinearAlgebra.RotateBy; } }
      /// <summary>Computes the linear interpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<int> Vector_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<int> Vector_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<int> Vector_Blerp { get { return LinearAlgebra.Blerp; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<int> Vector_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<int> Vector_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<int> Vector_RotateBy_quaternion { get { return LinearAlgebra.RotateBy; } }

      #endregion

      #region matrix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<int> Matrix_Negate { get { return LinearAlgebra.Negate; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<int> Matrix_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<int> Matrix_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<int> Matrix_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<int> Matrix_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Premultiplies a vector by a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<int> Matrix_Multiply_vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<int> Matrix_Divide { get { return LinearAlgebra.Divide; } }
      /// <summary>Takes the matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<int> Matrix_Power { get { return LinearAlgebra.Power; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<int> Matrix_Minor { get { return LinearAlgebra.Minor; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<int> Matrix_ConcatenateRowWise { get { return LinearAlgebra.ConcatenateRowWise; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<int> Matrix_Determinent { get { return LinearAlgebra.Determinent; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<int> Matrix_Echelon { get { return LinearAlgebra.Echelon; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<int> Matrix_ReducedEchelon { get { return LinearAlgebra.ReducedEchelon; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<int> Matrix_Inverse { get { return LinearAlgebra.Inverse; } }
      /// <summary>Gets the adjoint of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<int> Matrix_Adjoint { get { return LinearAlgebra.Adjoint; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<int> Matrix_Transpose { get { return LinearAlgebra.Transpose; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<int> Matrix_DecomposeLU { get { return LinearAlgebra.DecomposeLU; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<int> Matrix_EqualsByValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<int> Matrix_EqualsByValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<int> Quaternion_Magnitude { get { return LinearAlgebra.Magnitude; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<int> Quaternion_MagnitudeSquared { get { return LinearAlgebra.MagnitudeSquared; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<int> Quaternion_Conjugate { get { return LinearAlgebra.Conjugate; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<int> Quaternion_Add { get { return LinearAlgebra.Add; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<int> Quaternion_Subtract { get { return LinearAlgebra.Subtract; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<int> Quaternion_Multiply { get { return LinearAlgebra.Multiply; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<int> Quaternion_Multiply_scalar { get { return LinearAlgebra.Multiply; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<int> Quaternion_Multiply_Vector { get { return LinearAlgebra.Multiply; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<int> Quaternion_Normalize { get { return LinearAlgebra.Normalize; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<int> Quaternion_Invert { get { return LinearAlgebra.Invert; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<int> Quaternion_Lerp { get { return LinearAlgebra.Lerp; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<int> Quaternion_Slerp { get { return LinearAlgebra.Slerp; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<int> Quaternion_Rotate { get { return LinearAlgebra.Rotate; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<int> Quaternion_EqualsValue { get { return LinearAlgebra.EqualsValue; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<int> Quaternion_EqualsValue_leniency { get { return LinearAlgebra.EqualsValue; } }

      #endregion
    }

    /// <summary>Creates a linear algebra for an arbitray type.</summary>
    /// <typeparam name="T">The type to create a linear algebra library for.</typeparam>
    public class LinearAlgebra_generic<T> : LinearAlgebra<T>
    {
      #region field

      // Constants
      private T _zero;
      private T _one;
      private T _two;

      // Logic
      private Logic.delegates.abs<T> _abs;
      private Equate<T> _equate;
      private Compare<T> _compare;

      // Arithmetic
      private Arithmetic.delegates.Negate<T> _negate;
      private Arithmetic.delegates.Add<T> _add;
      private Arithmetic.delegates.Subtract<T> _subtract;
      private Arithmetic.delegates.Multiply<T> _multiply;
      private Arithmetic.delegates.Divide<T> _divide;

      // Algebra
      private Algebra.delegates.sqrt<T> _sqrt;
      private Algebra.delegates.invert<T> _Invert_Multiplicative;

      // Trigonometry
      private Trigonometry.delegates.sin<T> _sin;
      private Trigonometry.delegates.cos<T> _cos;
      private Trigonometry.delegates.acos<T> _acos;

      #endregion

      #region construct

      private LinearAlgebra_generic(
        T zero,
        T one,
        T two,
        Logic.delegates.abs<T> abs,
        Equate<T> equate,
        Compare<T> compare,
        Arithmetic.delegates.Negate<T> negate,
        Arithmetic.delegates.Add<T> add,
        Arithmetic.delegates.Subtract<T> subtract,
        Arithmetic.delegates.Multiply<T> multiply,
        Arithmetic.delegates.Divide<T> divide,
        Algebra.delegates.sqrt<T> sqrt,
        Algebra.delegates.invert<T> invert_mult,
        Trigonometry.delegates.sin<T> sin,
        Trigonometry.delegates.cos<T> cos,
        Trigonometry.delegates.acos<T> arccos)
      {
        _zero = zero;
        _one = one;
        _two = two;
        _abs = abs;
        _equate = equate;
        _compare = compare;
        _negate = negate;
        _add = add;
        _subtract = subtract;
        _multiply = multiply;
        _divide = divide;
        _sqrt = sqrt;
        _Invert_Multiplicative = invert_mult;
        _sin = sin;
        _cos = cos;
        _acos = arccos;
      }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<T> Vector_Add
      {
        get
        {
          return
            (T[] left, T[] right) =>
            {
              if (left.Length != right.Length)
                throw new Error("invalid dimensions on vector addition.");
              T[] result = new T[left.Length];
              for (int i = 0; i < left.Length; i++)
                result[i] = _add(left[i], right[i]);
              return result;
            };
        }
      }

      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<T> Vector_Negate
      {
        get
        {
          return
            (T[] vector) =>
            {
              T[] result = new T[vector.Length];
              for (int i = 0; i < vector.Length; i++)
                result[i] = _negate(vector[i]);
              return result;
            };
        }
      }

      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<T> Vector_Subtract
      {
        get
        {
          return
            (T[] left, T[] right) =>
            {
              T[] result = new T[left.Length];
              if (left.Length != right.Length)
                throw new Error("invalid dimensions on vector subtraction.");
              for (int i = 0; i < left.Length; i++)
                result[i] = _subtract(left[i], right[i]);
              return result;
            };
        }
      }

      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<T> Vector_Multiply
      {
        get
        {
          return
            (T[] left, T right) =>
            {
              T[] result = new T[left.Length];
              for (int i = 0; i < left.Length; i++)
                result[i] = _multiply(left[i], right);
              return result;
            };
        }
      }

      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<T> Vector_Divide
      {
        get
        {
          return
            (T[] left, T right) =>
            {
              T[] result = new T[left.Length];
              for (int i = 0; i < left.Length; i++)
                result[i] = _divide(left[i], right);
              return result;
            };
        }
      }

      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<T> Vector_DotProduct
      {
        get
        {
          return
            (T[] left, T[] right) =>
            {
              if (left.Length != right.Length)
                throw new Error("invalid dimensions on vector dot product.");
              T result = _zero;
              for (int i = 0; i < left.Length; i++)
                result = _add(result, _multiply(left[i], right[i]));
              return result;
            };
        }
      }

      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<T> Vector_CrossProduct
      {
        get
        {
          return
            (T[] left, T[] right) =>
            {
              if (left.Length != right.Length)
                throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
              if (left.Length == 3 || left.Length == 4)
              {
                return new T[] {
                _subtract(_multiply(left[1], right[2]), _multiply(left[2], right[1])),
                _subtract(_multiply(left[2], right[0]), _multiply(left[0], right[2])),
                _subtract(_multiply(left[0], right[1]), _multiply(left[1], right[0])) };
              }
              throw new Error("my cross product function is only defined for 3-component vectors.");
            };
        }
      }

      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<T> Vector_Normalize
      {
        get
        {
          return
            (T[] vector) =>
            {
              T length = Vector<T>.Magnitude(vector);
              if (!_equate(length, _zero))
              {
                T[] result = new T[vector.Length];
                for (int i = 0; i < vector.Length; i++)
                  result[i] = _divide(vector[i], length);
                return result;
              }
              else
                return new T[vector.Length];
            };
        }
      }

      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<T> Vector_Magnitude
      {
        get
        {
          return
            (T[] vector) =>
            {
              T result = _zero;
              for (int i = 0; i < vector.Length; i++)
                result = _add(result, _multiply(vector[i], vector[i]));
              return _sqrt(result);
            };
        }
      }

      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<T> Vector_MagnitudeSquared
      {
        get
        {
          return
            (T[] vector) =>
            {
              T result = _zero;
              for (int i = 0; i < vector.Length; i++)
                result = _add(result, _multiply(vector[i], vector[i]));
              return result;
            };
        }
      }

      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<T> Vector_Angle
      {
        get
        {
          return
            (T[] first, T[] second) =>
            {
              return _acos(_divide(Vector<T>.DotProduct(first, second), (_multiply(Vector<T>.Magnitude(first), Vector<T>.Magnitude(second)))));
            };
        }
      }

      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<T> Vector_RotateBy
      {
        get
        {
          return
            (T[] vector, T angle, T x, T y, T z) =>
            {
              if (vector.Length == 3)
              {
                // Note: the angle is in radians
                T sinHalfAngle = _sin(_divide(angle, _two));
                T cosHalfAngle = _cos(_divide(angle, _two));
                x = _multiply(x, sinHalfAngle);
                y = _multiply(y, sinHalfAngle);
                z = _multiply(z, sinHalfAngle);
                T x2 = _subtract(_add(_multiply(cosHalfAngle, vector[0]), _multiply(y, vector[2])), _multiply(z, vector[1]));
                T y2 = _subtract(_add(_multiply(cosHalfAngle, vector[1]), _multiply(z, vector[0])), _multiply(x, vector[2]));
                T z2 = _subtract(_add(_multiply(cosHalfAngle, vector[2]), _multiply(x, vector[1])), _multiply(y, vector[0]));
                T w2 = _add(_add(_multiply(_negate(x), vector[0]), _multiply(_negate(y), vector[1])), _multiply(_negate(z), vector[2]));
                return new T[] {
					_subtract(_add(_add(_multiply(x, w2), _multiply(cosHalfAngle, x2)), _multiply(y, z2)), _multiply(z, y2)),
					_subtract(_add(_add(_multiply(y, w2), _multiply(cosHalfAngle, y2)), _multiply(z, x2)), _multiply(x, z2)),
					_subtract(_add(_add(_multiply(z, w2), _multiply(cosHalfAngle, z2)), _multiply(x, y2)), _multiply(y, x2)) };
              }
              throw new Error("my RotateBy() function is only defined for 3-component vectors.");
            };
        }
      }

      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<T> Vector_RotateBy_quaternion
      {
        get
        {
          return
            (T[] vector, Quaternion<T> quaternion) =>
            {
              return this.Quaternion_Rotate(quaternion, vector);
            };
        }
      }


      /// <summary>Computes the linear Terpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<T> Vector_Lerp
      {
        get
        {
          return
            (T[] left, T[] right, T blend) =>
            {
              throw new System.NotImplementedException();
              //float[] leftFloats = left.Floats;
              //float[] rightFloats = right.Floats;
              //if (blend < 0 || blend > 1.0f)
              //	throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
              //if (leftFloats.Length != rightFloats.Length)
              //	throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
              //Vector<T> result = new Vector<T>(leftFloats.Length);
              //float[] resultFloats = result.Floats;
              //for (int i = 0; i < leftFloats.Length; i++)
              //	resultFloats[i] = leftFloats[i] + blend * (rightFloats[i] - leftFloats[i]);
              //return result;
            };
        }
      }

      /// <summary>Sphereically Terpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<T> Vector_Slerp
      {
        get
        {
          return
            (T[] left, T[] right, T blend) =>
            {
              throw new System.NotImplementedException();
              //if (blend < 0 || blend > 1.0f)
              //	throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
              //float dot = Calc.Clamp(Vector<T>.DotProduct(left, right), -1.0f, 1.0f);
              //float theta = Calc.ArcCos(dot) * blend;
              //return left * Calc.Cos(theta) + (right - left * dot).Normalize() * Calc.Sin(theta);
            };
        }
      }

      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<T> Vector_Blerp
      {
        get
        {
          return
            (T[] a, T[] b, T[] c, T u, T v) =>
            {
              throw new System.NotImplementedException();
              //return Vector<T>.Add(Vector<T>.Add(Vector<T>.Multiply(Vector<T>.Subtract(b, a), u), Vector<T>.Multiply(Vector<T>.Subtract(c, a), v)), a);
            };
        }
      }

      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<T> Vector_EqualsValue
      {
        get
        {
          return
            (T[] left, T[] right) =>
            {
              if (left.GetLength(0) != right.GetLength(0))
                return false;
              for (int i = 0; i < left.GetLength(0); i++)
                if (!_equate(left[i], right[i]))
                  return false;
              return true;
            };
        }
      }

      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<T> Vector_EqualsValue_leniency
      {
        get
        {
          return
            (T[] left, T[] right, T leniency) =>
            {
              if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
                return false;
              for (int i = 0; i < left.GetLength(0); i++)
                if (_compare(_abs(_subtract(left[i], right[i])), leniency) == Comparison.Greater)
                  return false;
              return true;
            };
        }
      }

      #endregion

      #region matix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<T> Matrix_Negate
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              T[,] result = new T[matrix.GetLength(0), matrix.GetLength(1)];
              for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                  result[i, j] = _negate(matrix[i, j]);
              return result;
            };
        }
      }

      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<T> Matrix_Add
      {
        get
        {
          return
            (T[,] left, T[,] right) =>
            {
              if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
                throw new Error("invalid addition (size miss-match).");
              T[,] result = new T[left.GetLength(0), left.GetLength(1)];
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < left.GetLength(1); j++)
                  result[i, j] = _add(left[i, j], right[i, j]);
              return result;
            };
        }
      }

      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<T> Matrix_Subtract
      {
        get
        {
          return
            (T[,] left, T[,] right) =>
            {
              if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
                throw new Error("invalid subtraction (size miss-match).");
              T[,] result = new T[left.GetLength(0), left.GetLength(1)];
              for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                  result[i, j] = _subtract(left[i, j], right[i, j]);
              return result;
            };
        }
      }

      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<T> Matrix_Multiply
      {
        get
        {
          return
            (T[,] left, T[,] right) =>
            {
              if (left.GetLength(1) != right.GetLength(0))
                throw new Error("invalid multiplication (size miss-match).");
              T[,] result = new T[left.GetLength(0), right.GetLength(1)];
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < right.GetLength(1); j++)
                  for (int k = 0; k < left.GetLength(1); k++)
                    result[i, j] = _add(result[i, j], _multiply(left[i, k], right[k, j]));
              return result;
            };
        }
      }

      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<T> Matrix_Multiply_scalar
      {
        get
        {
          return
            (T[,] left, T right) =>
            {
              T[,] result = new T[left.GetLength(0), left.GetLength(1)];
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < left.GetLength(1); j++)
                  result[i, j] = _multiply(left[i, j], right);
              return result;
            };
        }
      }

      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<T> Matrix_Multiply_vector
      {
        get
        {
          return
            (T[,] left, T[] right) =>
            {
              if (left.GetLength(1) != right.GetLength(0))
                throw new Error("invalid multiplication (size miss-match).");
              T[] result = new T[left.GetLength(1)];
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < right.GetLength(1); j++)
                  result[i] = _add(result[i], _multiply(left[i, j], right[j]));
              return result;
            };
        }
      }

      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<T> Matrix_Divide
      {
        get
        {
          return
            (T[,] matrix, T right) =>
            {
              T[,] result = new T[matrix.GetLength(0), matrix.GetLength(1)];
              for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                  result[i, j] = _divide(matrix[i, j], right);
              return result;
            };
        }
      }

      /// <summary>Takes a matrix to the given int power.</summary>
      public LinearAlgebra.delegates.Matrix_Power<T> Matrix_Power
      {
        get
        {
          return
            (T[,] matrix, int power) =>
            {
              if (!(matrix.GetLength(0) == matrix.GetLength(1)))
                throw new Error("invalid power (!matrix.IsSquare).");
              if (!(power > -1))
                throw new Error("invalid power !(power > -1)");
              if (power == 0)
                return Matrix<T>.FactoryIdentity(matrix.GetLength(0), matrix.GetLength(1));
              T[,] result = matrix.Clone() as T[,];
              for (int i = 0; i < power; i++)
                result = Matrix<T>.Multiply(result, result);
              return result;
            };
        }
      }

      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<T> Matrix_Minor
      {
        get
        {
          return
            (T[,] matrix, int row, int column) =>
            {
              T[,] minor = new T[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
              int m = 0, n = 0;
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                if (i == row) continue;
                n = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                  if (j == column) continue;
                  minor[m, n] = matrix[i, j];
                  n++;
                }
                m++;
              }
              return minor;
            };
        }
      }

      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<T> Matrix_ConcatenateRowWise
      {
        get
        {
          return
            (T[,] left, T[,] right) =>
            {
              if (left.GetLength(0) != right.GetLength(0))
                throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
              T[,] result = new T[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                {
                  if (j < left.GetLength(1)) result[i, j] = left[i, j];
                  else result[i, j] = right[i, j - left.GetLength(1)];
                }
              return result;
            };
        }
      }

      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<T> Matrix_Determinent
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              if (!(matrix.GetLength(0) == matrix.GetLength(1)))
                throw new Error("invalid determinent !(matrix.IsSquare).");
              T det = _one;
              try
              {
                T[,] rref = matrix.Clone() as T[,];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                  if (_equate(rref[i, i], _zero))
                    for (int j = i + 1; j < rref.GetLength(0); j++)
                      if (!_equate(rref[j, i], _zero))
                      {
                        this.SwapRows(rref, i, j);
                        det = _negate(det);
                      }
                  det = _multiply(det, rref[i, i]);
                  this.RowMultiplication(rref, i, _Invert_Multiplicative(rref[i, i]));
                  for (int j = i + 1; j < rref.GetLength(0); j++)
                    this.RowAddition(rref, j, i, _negate(rref[j, i]));
                  for (int j = i - 1; j >= 0; j--)
                    this.RowAddition(rref, j, i, _negate(rref[j, i]));
                }
                return det;
              }
              catch { throw new Error("determinent computation failed."); }
            };
        }
      }

      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<T> Matrix_Echelon
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              try
              {
                T[,] result = matrix.Clone() as T[,];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                  if (_equate(result[i, i], _zero))
                    for (int j = i + 1; j < result.GetLength(0); j++)
                      if (!_equate(result[j, i], _zero))
                        this.SwapRows(result, i, j);
                  if (_equate(result[i, i], _zero))
                    continue;
                  if (!_equate(result[i, i], _one))
                    for (int j = i + 1; j < result.GetLength(0); j++)
                      if (_equate(result[j, i], _one))
                        this.SwapRows(result, i, j);
                  this.RowMultiplication(result, i, _Invert_Multiplicative(result[i, i]));
                  for (int j = i + 1; j < result.GetLength(0); j++)
                    this.RowAddition(result, j, i, _negate(result[j, i]));
                }
                return result;
              }
              catch { throw new Error("echelon computation failed."); }
            };
        }
      }

      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<T> Matrix_ReducedEchelon
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              try
              {
                T[,] result = matrix.Clone() as T[,];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                  if (_equate(result[i, i], _one))
                    for (int j = i + 1; j < result.GetLength(0); j++)
                      if (!_equate(result[j, i], _zero))
                        this.SwapRows(result, i, j);
                  if (_equate(result[i, i], _zero)) continue;
                  if (!_equate(result[i, i], _one))
                    for (int j = i + 1; j < result.GetLength(0); j++)
                      if (_equate(result[j, i], _one))
                        this.SwapRows(result, i, j);
                  this.RowMultiplication(result, i, _Invert_Multiplicative(result[i, i]));
                  for (int j = i + 1; j < result.GetLength(0); j++)
                    this.RowAddition(result, j, i, _negate(result[j, i]));
                  for (int j = i - 1; j >= 0; j--)
                    this.RowAddition(result, j, i, _negate(result[j, i]));
                }
                return result;
              }
              catch { throw new Error("reduced echelon calculation failed."); }
            };
        }
      }

      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<T> Matrix_Inverse
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              if (_equate(Matrix<T>.Determinent(matrix), _zero))
                throw new Error("inverse calculation failed.");
              try
              {
                T[,] identity = Matrix<T>.FactoryIdentity(matrix.GetLength(0), matrix.GetLength(1));
                T[,] rref = matrix.Clone() as T[,];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                  if (_equate(rref[i, i], _zero))
                    for (int j = i + 1; j < rref.GetLength(0); j++)
                      if (!_equate(rref[j, i], _zero))
                      {
                        this.SwapRows(rref, i, j);
                        this.SwapRows(identity, i, j);
                      }
                  this.RowMultiplication(identity, i, _Invert_Multiplicative(rref[i, i]));
                  this.RowMultiplication(rref, i, _Invert_Multiplicative(rref[i, i]));
                  for (int j = i + 1; j < rref.GetLength(0); j++)
                  {
                    this.RowAddition(identity, j, i, _negate(rref[j, i]));
                    this.RowAddition(rref, j, i, _negate(rref[j, i]));
                  }
                  for (int j = i - 1; j >= 0; j--)
                  {
                    this.RowAddition(identity, j, i, _negate(rref[j, i]));
                    this.RowAddition(rref, j, i, _negate(rref[j, i]));
                  }
                }
                return identity;
              }
              catch { throw new Error("inverse calculation failed."); }
            };
        }
      }

      /// <summary>Gets the adjoT of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<T> Matrix_Adjoint
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              if (!(matrix.GetLength(0) == matrix.GetLength(1)))
                throw new Error("Adjoint of a non-square matrix does not exists");
              T[,] AdjointMatrix = new T[matrix.GetLength(0), matrix.GetLength(1)];
              for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                  if ((i + j) % 2 == 0)
                    AdjointMatrix[i, j] = Matrix<T>.Determinent(Matrix<T>.Minor(matrix, i, j));
                  else
                    AdjointMatrix[i, j] = _negate(Matrix<T>.Determinent(Matrix<T>.Minor(matrix, i, j)));
              return Matrix<T>.Transpose(AdjointMatrix);
            };
        }
      }

      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<T> Matrix_Transpose
      {
        get
        {
          return
            (T[,] matrix) =>
            {
              T[,] transpose = new T[matrix.GetLength(1), matrix.GetLength(0)];
              for (int i = 0; i < transpose.GetLength(0); i++)
                for (int j = 0; j < transpose.GetLength(1); j++)
                  transpose[i, j] = matrix[j, i];
              return transpose;
            };
        }
      }

      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<T> Matrix_DecomposeLU
      {
        get
        {
          return
            (T[,] matrix, out T[,] lower, out T[,] upper) =>
            {
              if (!(matrix.GetLength(0) == matrix.GetLength(1)))
                throw new Error("The matrix is not square!");
              lower = Matrix<T>.FactoryIdentity(matrix.GetLength(0), matrix.GetLength(1));
              upper = matrix.Clone() as T[,];
              int[] permutation = new int[matrix.GetLength(0)];
              for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
              T p = _zero, pom2, detOfP = _one;
              int k0 = 0, pom1 = 0;
              for (int k = 0; k < matrix.GetLength(1) - 1; k++)
              {
                p = _zero;
                for (int i = k; i < matrix.GetLength(0); i++)
                  if (_compare(_abs(upper[i, k]), p) == Comparison.Greater)
                  {
                    p = _abs(upper[i, k]);
                    k0 = i;
                  }
                if (_equate(p, _zero))
                  throw new Error("The matrix is singular!");
                pom1 = permutation[k];
                permutation[k] = permutation[k0];
                permutation[k0] = pom1;
                for (int i = 0; i < k; i++)
                {
                  pom2 = lower[k, i];
                  lower[k, i] = lower[k0, i];
                  lower[k0, i] = pom2;
                }
                if (k != k0)
                  detOfP = _negate(detOfP);
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                  pom2 = upper[k, i];
                  upper[k, i] = upper[k0, i];
                  upper[k0, i] = pom2;
                }
                for (int i = k + 1; i < matrix.GetLength(0); i++)
                {
                  lower[i, k] = _divide(upper[i, k], upper[k, k]);
                  for (int j = k; j < matrix.GetLength(1); j++)
                    upper[i, j] = _subtract(upper[i, j], _multiply(lower[i, k], upper[k, j]));
                }
              }
            };
        }
      }

      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<T> Matrix_EqualsByValue
      {
        get
        {
          return
            (T[,] left, T[,] right) =>
            {
              if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
                return false;
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < left.GetLength(1); j++)
                  if (!_equate(left[i, j], right[i, j]))
                    return false;
              return true;
            };
        }
      }

      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<T> Matrix_EqualsByValue_leniency
      {
        get
        {
          return
            (T[,] left, T[,] right, T leniency) =>
            {
              if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
                return false;
              for (int i = 0; i < left.GetLength(0); i++)
                for (int j = 0; j < left.GetLength(1); j++)
                  if (_compare(_abs(_subtract(left[i, j], right[i, j])), leniency) == Comparison.Greater)
                    return false;
              return true;
            };
        }
      }

      /// <summary>Does a value equality check.</summary>
      /// <param name="left">The first vector to check for equality.</param>
      /// <param name="right">The second vector  to check for equality.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public bool EqualsValue(T[] left, T[] right)
      {
        if (left.Length != right.Length)
          return false;
        for (int i = 0; i < left.Length; i++)
          if (!_equate(left[i], right[i]))
            return false;
        return true;
      }

      /// <summary>Does a value equality check with leniency.</summary>
      /// <param name="left">The first vector to check for equality.</param>
      /// <param name="right">The second vector to check for equality.</param>
      /// <param name="leniency">How much the values can vary but still be considered equal.</param>
      /// <returns>True if values are equal, false if not.</returns>
      public bool EqualsValue(T[] left, T[] right, T leniency)
      {
        if (left.Length != right.Length)
          return false;
        for (int i = 0; i < left.Length; i++)
          if (_compare(_abs(_subtract(left[i], right[i])), leniency) == Comparison.Greater)
            return false;
        return true;
      }

      private void RowMultiplication(T[,] matrix, int row, T scalar)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
          matrix[row, j] = _multiply(matrix[row, j], scalar);
      }

      private void RowAddition(T[,] matrix, int target, int second, T scalar)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
          matrix[target, j] = _add(matrix[target, j], _multiply(matrix[second, j], scalar));
      }

      private void SwapRows(T[,] matrix, int row1, int row2)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          T temp = matrix[row1, j];
          matrix[row1, j] = matrix[row2, j];
          matrix[row2, j] = temp;
        }
      }

      #endregion

      #region quaternion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<T> Quaternion_Magnitude
      { 
        get 
        {
          return
            (Quaternion<T> quaternion) =>
            {
              return
                _sqrt(_add(_add(_add(
                  _multiply(quaternion.X, quaternion.X),
                  _multiply(quaternion.Y, quaternion.Y)),
                  _multiply(quaternion.Z, quaternion.Z)),
                  _multiply(quaternion.W, quaternion.W)));
            };
        } 
      }

      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<T> Quaternion_MagnitudeSquared
      {
        get
        {
          return
            (Quaternion<T> quaternion) =>
            {
              return
                _add(_add(_add(
                  _multiply(quaternion.X, quaternion.X),
                  _multiply(quaternion.Y, quaternion.Y)),
                  _multiply(quaternion.Z, quaternion.Z)),
                  _multiply(quaternion.W, quaternion.W));
            };
        }
      }

      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<T> Quaternion_Conjugate
      {
        get
        {
          return
            (Quaternion<T> quaternion) =>
            {
              return new Quaternion<T>(
                _negate(quaternion.X),
                _negate(quaternion.Y),
                _negate(quaternion.Z),
                quaternion.W);
            };
        }
      }

      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<T> Quaternion_Add
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right) =>
            {
              return new Quaternion<T>(
                _add(left.X, right.X),
                _add(left.Y, right.Y),
                _add(left.Z, right.Z),
                _add(left.W, right.W));
            };
        }
      }

      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<T> Quaternion_Subtract
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right) =>
            {
              return new Quaternion<T>(
                _subtract(left.X, right.X),
                _subtract(left.Y, right.Y),
                _subtract(left.Z, right.Z),
                _subtract(left.W, right.W));
            };
        }
      }

      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<T> Quaternion_Multiply
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right) =>
            {
              return new Quaternion<T>(
                _subtract(_add(_add(_multiply(left.X, right.W), _multiply(left.W, right.X)), _multiply(left.Y, right.Z)), _multiply(left.Z, right.Y)),
                _subtract(_add(_add(_multiply(left.Y, right.W), _multiply(left.W, right.Y)), _multiply(left.Z, right.X)), _multiply(left.X, right.Z)),
                _subtract(_add(_add(_multiply(left.Z, right.W), _multiply(left.W, right.Z)), _multiply(left.X, right.Y)), _multiply(left.Y, right.X)),
                _subtract(_subtract(_subtract(_multiply(left.W, right.W), _multiply(left.X, right.X)), _multiply(left.Y, right.Y)), _multiply(left.Z, right.Z)));
            };
        }
      }

      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<T> Quaternion_Multiply_scalar
      {
        get
        {
          return
            (Quaternion<T> left, T right) =>
            {
              return new Quaternion<T>(
                _multiply(left.X, right),
                _multiply(left.Y, right),
                _multiply(left.Z, right),
                _multiply(left.W, right));
            };
        }
      }

      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<T> Quaternion_Multiply_Vector
      {
        get
        {
          return
            (Quaternion<T> left, Vector<T> right) =>
            {
              if (right.Dimensions == 3)
              {
                return new Quaternion<T>(
                  _subtract(_add(_multiply(left.W, right.X), _multiply(left.Y, right.Z)), _multiply(left.Z, right.Y)),
                  _subtract(_add(_multiply(left.W, right.Y), _multiply(left.Z, right.X)), _multiply(left.X, right.Z)),
                  _subtract(_add(_multiply(left.W, right.Z), _multiply(left.X, right.Y)), _multiply(left.Y, right.X)),
                  _subtract(_subtract(_multiply(_negate(left.X), right.X), _multiply(left.Y, right.Y)), _multiply(left.Z, right.Z)));
              }
              else
                throw new Error("my quaternion rotations are only defined for 3-component vectors.");
            };
        }
      }

      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<T> Quaternion_Normalize
      {
        get
        {
          return
            (Quaternion<T> quaternion) =>
            {
              T normalizer = Quaternion<T>.Magnitude(quaternion);
              if (!_equate(normalizer, _zero))
                return quaternion * _Invert_Multiplicative(normalizer);
              else
                return Quaternion<T>.FactoryIdentity;
            };
        }
      }

      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<T> Quaternion_Invert
      {
        get
        {
          return
            (Quaternion<T> quaternion) =>
            {
              // EQUATION: invert = quaternion.Conjugate()).Normalized()
              T normalizer = Quaternion<T>.MagnitudeSquared(quaternion);
              if (_equate(normalizer, _zero))
                return new Quaternion<T>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
              normalizer = _Invert_Multiplicative(normalizer);
              return new Quaternion<T>(
                _multiply(_negate(quaternion.X), normalizer),
                _multiply(_negate(quaternion.Y), normalizer),
                _multiply(_negate(quaternion.Z), normalizer),
                _multiply(quaternion.W, normalizer));
            };
        }
      }

      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<T> Quaternion_Lerp
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right, T blend) =>
            {
              if (_compare(blend, _zero) == Comparison.Less || _compare(blend, _one) == Comparison.Greater)
                throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
              if (_equate(Quaternion<T>.MagnitudeSquared(left), _zero))
              {
                if (_equate(Quaternion<T>.MagnitudeSquared(right), _zero))
                  return Quaternion<T>.FactoryIdentity;
                else
                  return new Quaternion<T>(right.X, right.Y, right.Z, right.W);
              }
              else if (_equate(Quaternion<T>.MagnitudeSquared(right), _zero))
                return new Quaternion<T>(left.X, left.Y, left.Z, left.W);
              Quaternion<T> result = new Quaternion<T>(
                _add(_multiply(_subtract(_one, blend), left.X), _multiply(blend, right.X)),
                _add(_multiply(_subtract(_one, blend), left.Y), _multiply(blend, right.Y)),
                _add(_multiply(_subtract(_one, blend), left.Z), _multiply(blend, right.Z)),
                _add(_multiply(_subtract(_one, blend), left.W), _multiply(blend, right.W)));
              if (_compare(Quaternion<T>.MagnitudeSquared(result), _zero) == Comparison.Greater)
                return Quaternion<T>.Normalize(result);
              else
                return Quaternion<T>.FactoryIdentity;
            };
        }
      }

      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<T> Quaternion_Slerp
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right, T blend) =>
            {
              throw new System.NotImplementedException();
              //if (_compare(blend, _zero) == Comparison.Less || _compare(blend, _one) == Comparison.Greater)
              //	throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
              //if (_equate(Quaternion<T>.MagnitudeSquared(left), _zero))
              //{
              //	if (_equate(Quaternion<T>.MagnitudeSquared(right), _zero))
              //		return FactoryIdentity;
              //	else
              //		return new Quaternion<T>(right.X, right.Y, right.Z, right.W);
              //}
              //else if (_equate(Quaternion<T>.MagnitudeSquared(right), _zero))
              //	return new Quaternion<T>(left.X, left.Y, left.Z, left.W);
              //float cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
              //if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
              //	return new Quaternion<T>(left.X, left.Y, left.Z, left.W);
              //else if (cosHalfAngle < 0.0f)
              //{
              //	right = new Quaternion<T>(-left.X, -left.Y, -left.Z, -left.W);
              //	cosHalfAngle = -cosHalfAngle;
              //}
              //float halfAngle = (float)Math.Acos(cosHalfAngle);
              //float sinHalfAngle = Calc.Sin(halfAngle);
              //float blendA = Calc.Sin(halfAngle * (_subtract(_one, blend)) / sinHalfAngle;
              //float blendB = Calc.Sin(halfAngle * blend) / sinHalfAngle;
              //Quaternion<T> result = new Quaternion<T>(
              //	blendA * left.X + blendB * right.X,
              //	blendA * left.Y + blendB * right.Y,
              //	blendA * left.Z + blendB * right.Z,
              //	blendA * left.W + blendB * right.W);
              //if (_compare(Quaternion<T>.MagnitudeSquared(result), _zero) == Comparison.Greater)
              //	return Quaternion<T>.Normalize(result);
              //else
              //	return Quaternion<T>.FactoryIdentity;
            };
        }
      }

      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<T> Quaternion_Rotate
      {
        get
        {
          return
            (Quaternion<T> rotation, Vector<T> vector) =>
            {
              if (vector.Dimensions != 3)
                throw new Error("my quaternion rotations are only defined for 3-component vectors.");
              Quaternion<T> answer = this.Quaternion_Multiply(this.Quaternion_Multiply_Vector(rotation, vector), Quaternion<T>.Conjugate(rotation));
              return new Vector<T>(answer.X, answer.Y, answer.Z);
            };
        }
      }

      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<T> Quaternion_EqualsValue
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right) =>
            {
              return
                _equate(left.X, right.X) &&
                _equate(left.Y, right.Y) &&
                _equate(left.Z, right.Z) &&
                _equate(left.W, right.W);
            };
        }
      }

      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<T> Quaternion_EqualsValue_leniency
      {
        get
        {
          return
            (Quaternion<T> left, Quaternion<T> right, T leniency) =>
            {
              return
                _compare(_abs(_subtract(left.X, right.X)), leniency) == Comparison.Less &&
                _compare(_abs(_subtract(left.Y, right.Y)), leniency) == Comparison.Less &&
                _compare(_abs(_subtract(left.Z, right.Z)), leniency) == Comparison.Less &&
                _compare(_abs(_subtract(left.W, right.W)), leniency) == Comparison.Less;
            };
        }
      }

      #endregion
    }

    private class LinearAlgebra_unsupported<T> : LinearAlgebra<T>
    {
      #region construct

      public LinearAlgebra_unsupported() { }

      #endregion

      #region vector

      /// <summary>Adds two vectors together.</summary>
      public LinearAlgebra.delegates.Vector_Add<T> Vector_Add
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Negates all the values in a vector.</summary>
      public LinearAlgebra.delegates.Vector_Negate<T> Vector_Negate
      { get { return (T[] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Subtracts two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Subtract<T> Vector_Subtract
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Multiply<T> Vector_Multiply
      { get { return (T[] left, T right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Divides all the components of a vector by a scalar.</summary>
      public LinearAlgebra.delegates.Vector_Divide<T> Vector_Divide
      { get { return (T[] left, T right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the dot product between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_DotProduct<T> Vector_DotProduct
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes teh cross product of two vectors.</summary>
      public LinearAlgebra.delegates.Vector_CrossProduct<T> Vector_CrossProduct
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Normalizes a vector.</summary>
      public LinearAlgebra.delegates.Vector_Normalize<T> Vector_Normalize
      { get { return (T[] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the length of a vector.</summary>
      public LinearAlgebra.delegates.Vector_Magnitude<T> Vector_Magnitude
      { get { return (T[] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
      public LinearAlgebra.delegates.Vector_MagnitudeSquared<T> Vector_MagnitudeSquared
      { get { return (T[] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the angle between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Angle<T> Vector_Angle
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy<T> Vector_RotateBy
      { get { return (T[] left, T angle, T x, T y, T z) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the linear Terpolation between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Lerp<T> Vector_Lerp
      { get { return (T[] left, T[] right, T blend) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Sphereically Terpolates between two vectors.</summary>
      public LinearAlgebra.delegates.Vector_Slerp<T> Vector_Slerp
      { get { return (T[] left, T[] right, T blend) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
      public LinearAlgebra.delegates.Vector_Blerp<T> Vector_Blerp
      { get { return (T[] a, T[] b, T[] c, T u, T v) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Checks for equality by value.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue<T> Vector_EqualsValue
      { get { return (T[] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Checks for equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Vector_EqualsValue_leniency<T> Vector_EqualsValue_leniency
      { get { return (T[] left, T[] right, T leniency) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Rotates a vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Vector_RotateBy_quaternion<T> Vector_RotateBy_quaternion
      { get { return (T[] left, Quaternion<T> right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }

      #endregion

      #region matrix

      /// <summary>Negates all the values in this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Negate<T> Matrix_Negate
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Does a standard matrix addition.</summary>
      public LinearAlgebra.delegates.Matrix_Add<T> Matrix_Add
      { get { return (T[,] left, T[,] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Does a standard matrix subtraction.</summary>
      public LinearAlgebra.delegates.Matrix_Subtract<T> Matrix_Subtract
      { get { return (T[,] left, T[,] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
      public LinearAlgebra.delegates.Matrix_Multiply<T> Matrix_Multiply
      { get { return (T[,] left, T[,] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_scalar<T> Matrix_Multiply_scalar
      { get { return (T[,] left, T right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Multiply_vector<T> Matrix_Multiply_vector
      { get { return (T[,] left, T[] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Divide<T> Matrix_Divide
      { get { return (T[,] left, T right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Divides all the values in this matrix by a scalar.</summary>
      public LinearAlgebra.delegates.Matrix_Power<T> Matrix_Power
      { get { return (T[,] left, int right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Gets the minor of a matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Minor<T> Matrix_Minor
      { get { return (T[,] left, int row, int column) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Combines two matrices from left to right (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
      public LinearAlgebra.delegates.Matrix_ConcatenateRowWise<T> Matrix_ConcatenateRowWise
      { get { return (T[,] left, T[,] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the determinent if this matrix is square.</summary>
      public LinearAlgebra.delegates.Matrix_Determinent<T> Matrix_Determinent
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
      public LinearAlgebra.delegates.Matrix_Echelon<T> Matrix_Echelon
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
      public LinearAlgebra.delegates.Matrix_ReducedEchelon<T> Matrix_ReducedEchelon
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the inverse of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Inverse<T> Matrix_Inverse
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Gets the adjoT of this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Adjoint<T> Matrix_Adjoint
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Transposes this matrix.</summary>
      public LinearAlgebra.delegates.Matrix_Transpose<T> Matrix_Transpose
      { get { return (T[,] left) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Decomposes a matrix to lower/upper components.</summary>
      public LinearAlgebra.delegates.Matrix_DecomposeLU<T> Matrix_DecomposeLU
      { get { return (T[,] m, out T[,] l, out T[,] u) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Dtermines equality but value.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue<T> Matrix_EqualsByValue
      { get { return (T[,] left, T[,] right) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Determines equality by value with leniency.</summary>
      public LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<T> Matrix_EqualsByValue_leniency
      { get { return (T[,] left, T[,] right, T leniency) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }

      #endregion

      #region quaterion

      /// <summary>Computes the length of quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Magnitude<T> Quaternion_Magnitude
      { get { return (Quaternion<T> a) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Computes the length of a quaternion, but doesn't square root it.</summary>
      public LinearAlgebra.delegates.Quaternion_MagnitudeSquared<T> Quaternion_MagnitudeSquared
      { get { return (Quaternion<T> a) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Gets the conjugate of the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Conjugate<T> Quaternion_Conjugate
      { get { return (Quaternion<T> a) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Adds two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Add<T> Quaternion_Add
      { get { return (Quaternion<T> a, Quaternion<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Subtracts two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Subtract<T> Quaternion_Subtract
      { get { return (Quaternion<T> a, Quaternion<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Multiplies two quaternions together.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply<T> Quaternion_Multiply
      { get { return (Quaternion<T> a, Quaternion<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_scalar<T> Quaternion_Multiply_scalar
      { get { return (Quaternion<T> a, T b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Multiply_Vector<T> Quaternion_Multiply_Vector
      { get { return (Quaternion<T> a, Vector<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Normalizes the quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Normalize<T> Quaternion_Normalize
      { get { return (Quaternion<T> a) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Inverts a quaternion.</summary>
      public LinearAlgebra.delegates.Quaternion_Invert<T> Quaternion_Invert
      { get { return (Quaternion<T> a) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Lenearly interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Lerp<T> Quaternion_Lerp
      { get { return (Quaternion<T> a, Quaternion<T> b, T blend) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Sphereically interpolates between two quaternions.</summary>
      public LinearAlgebra.delegates.Quaternion_Slerp<T> Quaternion_Slerp
      { get { return (Quaternion<T> a, Quaternion<T> b, T blend) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
      public LinearAlgebra.delegates.Quaternion_Rotate<T> Quaternion_Rotate
      { get { return (Quaternion<T> a, Vector<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Does a value equality check.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue<T> Quaternion_EqualsValue
      { get { return (Quaternion<T> a, Quaternion<T> b) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }
      /// <summary>Does a value equality check with leniency.</summary>
      public LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<T> Quaternion_EqualsValue_leniency
      { get { return (Quaternion<T> a, Quaternion<T> b, T leniency) => { throw new Error("a linear algebra for " + typeof(T) + " could not be found or created"); }; } }

      #endregion
    }

    #endregion

    #endregion

    #region implementations

    #region generic

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static T[] Add<T>(T[] left, T[] right)
    {
      return Get<T>().Vector_Add(left, right);
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static T[] Negate<T>(T[] vector)
    {
      return Get<T>().Vector_Negate(vector);
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static T[] Subtract<T>(T[] left, T[] right)
    {
      return Get<T>().Vector_Subtract(left, right);
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static T[] Multiply<T>(T[] left, T right)
    {
      return Get<T>().Vector_Multiply(left, right);
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static T[] Divide<T>(T[] vector, T right)
    {
      return Get<T>().Vector_Divide(vector, right);
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static T DotProduct<T>(T[] left, T[] right)
    {
      return Get<T>().Vector_DotProduct(left, right);
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static T[] CrossProduct<T>(T[] left, T[] right)
    {
      return Get<T>().Vector_CrossProduct(left, right);
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static T[] Normalize<T>(T[] vector)
    {
      return Get<T>().Vector_Normalize(vector);
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static T Magnitude<T>(T[] vector)
    {
      return Get<T>().Vector_Magnitude(vector);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static T MagnitudeSquared<T>(T[] vector)
    {
      return Get<T>().Vector_MagnitudeSquared(vector);
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static T Angle<T>(T[] first, T[] second)
    {
      return Get<T>().Vector_Angle(first, second);
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static T[] RotateBy<T>(T[] vector, T angle, T x, T y, T z)
    {
      return Get<T>().Vector_RotateBy(vector, angle, x, y, z);
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static T[] RotateBy<T>(T[] vector, Quaternion<T> quaternion)
    {
      return Get<T>().Vector_RotateBy_quaternion(vector, quaternion);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static T[] Lerp<T>(T[] left, T[] right, T blend)
    {
      return Get<T>().Vector_Lerp(left, right, blend);
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static T[] Slerp<T>(T[] left, T[] right, T blend)
    {
      return Get<T>().Vector_Slerp(left, right, blend);
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static T[] Blerp<T>(T[] a, T[] b, T[] c, T u, T v)
    {
      return Get<T>().Vector_Blerp(a, b, c, u, v);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(T[] left, T[] right)
    {
      return Get<T>().Vector_EqualsValue(left, right);
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(T[] left, T[] right, T leniency)
    {
      return Get<T>().Vector_EqualsValue_leniency(left, right, leniency);
    }

    #endregion

    #region matrix

    ///// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    ///// <param name="rows">The number of rows of the matrix.</param>
    ///// <param name="columns">The number of columns of the matrix.</param>
    ///// <returns>The newly constructed identity-matrix.</returns>
    //public static T[,] MatrixFactoryIdentity_T<T>(int rows, int columns)
    //{
    //  return Get<T>().Matrix_Add(left, right);
    //}

    ///// <summary>Determines if a matrix is symetric or not.</summary>
    ///// <param name="matrix">The matrix to determine symetry of.</param>
    ///// <returns>True if symetric; false if not.</returns>
    //public static bool IsSymmetric<T>(T[,] matrix)
    //{
    //  return Get<T>().Matrix_IsSymetric(matrix);
    //}

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static T[,] Negate<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Negate(matrix);
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static T[,] Add<T>(T[,] left, T[,] right)
    {
      return Get<T>().Matrix_Add(left, right);
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static T[,] Subtract<T>(T[,] left, T[,] right)
    {
      return Get<T>().Matrix_Add(left, right);
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static T[,] Multiply<T>(T[,] left, T[,] right)
    {
      return Get<T>().Matrix_Multiply(left, right);
    }

    /// <summary>Does a standard <T>(triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static T[] Multiply<T>(T[,] left, T[] right)
    {
      return Get<T>().Matrix_Multiply_vector(left, right);
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static T[,] Multiply<T>(T[,] left, T right)
    {
      return Get<T>().Matrix_Multiply_scalar(left, right);
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static T[,] Power<T>(T[,] matrix, int power)
    {
      return Get<T>().Matrix_Power(matrix, power);
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static T[,] Divide<T>(T[,] matrix, T right)
    {
      return Get<T>().Matrix_Divide(matrix, right);
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static T[,] Minor<T>(T[,] matrix, int row, int column)
    {
      return Get<T>().Matrix_Minor(matrix, row, column);
    }

    /// <summary>Combines two matrices from left to right 
    /// <T>(result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static T[,] ConcatenateRowWise<T>(T[,] left, T[,] right)
    {
      return Get<T>().Matrix_ConcatenateRowWise(left, right);
    }

    /// <summary>Calculates the echelon of a matrix <T>(aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of <T>(aka REF).</param>
    /// <returns>The echelon of the matrix <T>(aka REF).</returns>
    public static T[,] Echelon<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Echelon(matrix);
    }

    /// <summary>Calculates the echelon of a matrix and reduces it <T>(aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of <T>(aka RREF).</param>
    /// <returns>The reduced echelon of the matrix <T>(aka RREF).</returns>
    public static T[,] ReducedEchelon<T>(T[,] matrix)
    {
      return Get<T>().Matrix_ReducedEchelon(matrix);
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static T Determinent<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Determinent(matrix);
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static T[,] Inverse<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Inverse(matrix);
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static T[,] Adjoint<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Adjoint(matrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static T[,] Transpose<T>(T[,] matrix)
    {
      return Get<T>().Matrix_Transpose(matrix);
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU<T>(T[,] matrix, out T[,] Lower, out T[,] Upper)
    {
      Get<T>().Matrix_DecomposeLU(matrix, out Lower, out Upper);
    }

    ///// <summary>Creates a copy of a matrix.</summary>
    ///// <param name="matrix">The matrix to copy.</param>
    ///// <returns>A copy of the matrix.</returns>
    //public static T[,] Clone<T>(T[,] matrix)
    //{
    //  return Get<T>().Matrix_Clone(matrix);
    //}

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(T[,] left, T[,] right)
    {
      return Get<T>().Matrix_EqualsByValue(left, right);
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(T[,] left, T[,] right, T leniency)
    {
      return Get<T>().Matrix_EqualsByValue_leniency(left, right, leniency);
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static T Magnitude<T>(Quaternion<T> quaternion)
    {
      return Get<T>().Quaternion_Magnitude(quaternion);
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static T MagnitudeSquared<T>(Quaternion<T> quaternion)
    {
      return Get<T>().Quaternion_MagnitudeSquared(quaternion);
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<T> Conjugate<T>(Quaternion<T> quaternion)
    {
      return Get<T>().Quaternion_Conjugate(quaternion);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<T> Add<T>(Quaternion<T> left, Quaternion<T> right)
    {
      return Get<T>().Quaternion_Add(left, right);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<T> Subtract<T>(Quaternion<T> left, Quaternion<T> right)
    {
      return Get<T>().Quaternion_Subtract(left, right);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<T> Multiply<T>(Quaternion<T> left, Quaternion<T> right)
    {
      return Get<T>().Quaternion_Multiply(left, right);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<T> Multiply<T>(Quaternion<T> left, T right)
    {
      return Get<T>().Quaternion_Multiply_scalar(left, right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<T> Multiply<T>(Quaternion<T> left, Vector<T> right)
    {
      return Get<T>().Quaternion_Multiply_Vector(left, right);
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<T> Normalize<T>(Quaternion<T> quaternion)
    {
      return Get<T>().Quaternion_Normalize(quaternion);
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<T> Invert<T>(Quaternion<T> quaternion)
    {
      return Get<T>().Quaternion_Invert(quaternion);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<T> Lerp<T>(Quaternion<T> left, Quaternion<T> right, T blend)
    {
      return Get<T>().Quaternion_Lerp(left, right, blend);
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<T> Slerp<T>(Quaternion<T> left, Quaternion<T> right, T blend)
    {
      return Get<T>().Quaternion_Slerp(left, right, blend);
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<T> Rotate<T>(Quaternion<T> rotation, Vector<T> vector)
    {
      return Get<T>().Quaternion_Rotate(rotation, vector);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(Quaternion<T> left, Quaternion<T> right)
    {
      return Get<T>().Quaternion_EqualsValue(left, right);
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue<T>(Quaternion<T> left, Quaternion<T> right, T leniency)
    {
      return Get<T>().Quaternion_EqualsValue_leniency(left, right, leniency);
    }

    #endregion

    #endregion

    #region Fraction128

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static Fraction128[] Add(Fraction128[] left, Fraction128[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      Fraction128[] result = new Fraction128[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static Fraction128[] Negate(Fraction128[] vector)
    {
      Fraction128[] result = new Fraction128[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static Fraction128[] Subtract(Fraction128[] left, Fraction128[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      Fraction128[] result = new Fraction128[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static Fraction128[] Multiply(Fraction128[] left, Fraction128 right)
    {
      Fraction128[] result = new Fraction128[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static Fraction128[] Divide(Fraction128[] vector, Fraction128 right)
    {
      Fraction128[] result = new Fraction128[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static Fraction128 DotProduct(Fraction128[] left, Fraction128[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      Fraction128 result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static Fraction128[] CrossProduct(Fraction128[] left, Fraction128[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new Fraction128[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static Fraction128[] Normalize(Fraction128[] vector)
    {
      Fraction128 length = LinearAlgebra.Magnitude(vector);
      if (length != 0)
      {
        Fraction128[] result = new Fraction128[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new Fraction128[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static Fraction128 Magnitude(Fraction128[] vector)
    {
      Fraction128 result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (Fraction128)System.Math.Sqrt((double)result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static Fraction128 MagnitudeSquared(Fraction128[] vector)
    {
      Fraction128 result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static Fraction128 Angle(Fraction128[] first, Fraction128[] second)
    {
      return (Fraction128)System.Math.Acos((double)(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second))));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static Fraction128[] RotateBy(Fraction128[] vector, Fraction128 angle, Fraction128 x, Fraction128 y, Fraction128 z)
    {
      if (vector.Length == 3)
      {
        // Note: the angle is in radians
        Fraction128 sinHalfAngle = (Fraction128)System.Math.Sin((double)angle / 2d);
        Fraction128 cosHalfAngle = (Fraction128)System.Math.Cos((double)angle / 2d);
        x *= sinHalfAngle;
        y *= sinHalfAngle;
        z *= sinHalfAngle;
        Fraction128 x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
        Fraction128 y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
        Fraction128 z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
        Fraction128 w2 = -x * vector[0] - y * vector[1] - z * vector[2];
        return new Fraction128[] {
          x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
          y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
          z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      }
      throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static Fraction128[] RotateBy(Fraction128[] vector, Quaternion<Fraction128> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Fraction128[] Lerp(Fraction128[] left, Fraction128[] right, Fraction128 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      Fraction128[] result = new Fraction128[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static Fraction128[] Slerp(Fraction128[] left, Fraction128[] right, Fraction128 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      Fraction128 dot = LinearAlgebra.DotProduct(left, right);
      dot = dot < -1 ? -1 : dot;
      dot = dot > 1 ? 1 : dot;
      Fraction128 theta = (Fraction128)System.Math.Acos((double)dot) * blend;
      return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, (Fraction128)System.Math.Cos((double)theta)),
        LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), (Fraction128)System.Math.Sin((double)theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static Fraction128[] Blerp(Fraction128[] a, Fraction128[] b, Fraction128[] c, Fraction128 u, Fraction128 v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction128[] left, Fraction128[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction128[] left, Fraction128[] right, Fraction128 leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static Fraction128[,] MatrixFactoryIdentity_Fraction128(int rows, int columns)
    {
      Fraction128[,] matrix;
      try { matrix = new Fraction128[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(Fraction128[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Fraction128[,] Negate(Fraction128[,] matrix)
    {
      Fraction128[,] result = new Fraction128[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static Fraction128[,] Add(Fraction128[,] left, Fraction128[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      Fraction128[,] result = new Fraction128[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static Fraction128[,] Subtract(Fraction128[,] left, Fraction128[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      Fraction128[,] result = new Fraction128[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction128[,] Multiply(Fraction128[,] left, Fraction128[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      Fraction128[,] result = new Fraction128[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction128[] Multiply(Fraction128[,] left, Fraction128[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      Fraction128[] result = new Fraction128[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j] * right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Fraction128[,] Multiply(Fraction128[,] left, Fraction128 right)
    {
      Fraction128[,] result = new Fraction128[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static Fraction128[,] Power(Fraction128[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_Fraction128(matrix.GetLength(0), matrix.GetLength(1));
      Fraction128[,] result = matrix.Clone() as Fraction128[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static Fraction128[,] Divide(Fraction128[,] matrix, Fraction128 right)
    {
      Fraction128[,] result = new Fraction128[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static Fraction128[,] Minor(Fraction128[,] matrix, int row, int column)
    {
      Fraction128[,] minor = new Fraction128[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static Fraction128[,] ConcatenateRowWise(Fraction128[,] left, Fraction128[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      Fraction128[,] result = new Fraction128[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static Fraction128[,] Echelon(Fraction128[,] matrix)
    {
      try
      {
        Fraction128[,] result = matrix.Clone() as Fraction128[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static Fraction128[,] ReducedEchelon(Fraction128[,] matrix)
    {
      try
      {
        Fraction128[,] result = matrix.Clone() as Fraction128[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static Fraction128 Determinent(Fraction128[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        Fraction128 det = 1;
        Fraction128[,] rref = matrix.Clone() as Fraction128[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static Fraction128[,] Inverse(Fraction128[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        Fraction128[,] identity = LinearAlgebra.MatrixFactoryIdentity_Fraction128(matrix.GetLength(0), matrix.GetLength(1));
        Fraction128[,] rref = matrix.Clone() as Fraction128[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static Fraction128[,] Adjoint(Fraction128[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      Fraction128[,] AdjointMatrix = new Fraction128[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static Fraction128[,] Transpose(Fraction128[,] matrix)
    {
      Fraction128[,] transpose = new Fraction128[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(Fraction128[,] matrix, out Fraction128[,] Lower, out Fraction128[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_Fraction128(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as Fraction128[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      Fraction128 p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static Fraction128[,] Clone(Fraction128[,] matrix)
    {
      Fraction128[,] result = new Fraction128[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(Fraction128[,] matrix, int row, Fraction128 scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(Fraction128[,] matrix, int target, int second, Fraction128 scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(Fraction128[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Fraction128 temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction128[,] left, Fraction128[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction128[,] left, Fraction128[,] right, Fraction128 leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static Fraction128 Magnitude(Quaternion<Fraction128> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static Fraction128 MagnitudeSquared(Quaternion<Fraction128> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<Fraction128> Conjugate(Quaternion<Fraction128> quaternion)
    {
      return new Quaternion<Fraction128>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<Fraction128> Add(Quaternion<Fraction128> left, Quaternion<Fraction128> right)
    {
      return new Quaternion<Fraction128>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<Fraction128> Subtract(Quaternion<Fraction128> left, Quaternion<Fraction128> right)
    {
      return new Quaternion<Fraction128>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<Fraction128> Multiply(Quaternion<Fraction128> left, Quaternion<Fraction128> right)
    {
      return new Quaternion<Fraction128>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<Fraction128> Multiply(Quaternion<Fraction128> left, Fraction128 right)
    {
      return new Quaternion<Fraction128>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<Fraction128> Multiply(Quaternion<Fraction128> left, Vector<Fraction128> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<Fraction128>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<Fraction128> Normalize(Quaternion<Fraction128> quaternion)
    {
      Fraction128 normalizer = Quaternion<Fraction128>.Magnitude(quaternion);
      if (normalizer != 0)
        return quaternion * (1 / normalizer);
      else
        return Quaternion<Fraction128>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<Fraction128> Invert(Quaternion<Fraction128> quaternion)
    {
      Fraction128 normalizer = Quaternion<Fraction128>.MagnitudeSquared(quaternion);
      if (normalizer == 0)
        return new Quaternion<Fraction128>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1 / normalizer;
      return new Quaternion<Fraction128>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<Fraction128> Lerp(Quaternion<Fraction128> left, Quaternion<Fraction128> right, Fraction128 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (Quaternion<Fraction128>.MagnitudeSquared(left) == 0)
      {
        if (Quaternion<Fraction128>.MagnitudeSquared(right) == 0)
          return Quaternion<Fraction128>.FactoryIdentity;
        else
          return new Quaternion<Fraction128>(right.X, right.Y, right.Z, right.W);
      }
      else if (Quaternion<Fraction128>.MagnitudeSquared(right) == 0)
        return new Quaternion<Fraction128>(left.X, left.Y, left.Z, left.W);
      Quaternion<Fraction128> result = new Quaternion<Fraction128>(
        1 - blend * left.X + blend * right.X,
        1 - blend * left.Y + blend * right.Y,
        1 - blend * left.Z + blend * right.Z,
        1 - blend * left.W + blend * right.W);
      if (Quaternion<Fraction128>.MagnitudeSquared(result) > 0)
        return Quaternion<Fraction128>.Normalize(result);
      else
        return Quaternion<Fraction128>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<Fraction128> Slerp(Quaternion<Fraction128> left, Quaternion<Fraction128> right, Fraction128 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (LinearAlgebra.MagnitudeSquared(left) == 0)
      {
        if (LinearAlgebra.MagnitudeSquared(right) == 0)
          return Quaternion<Fraction128>.FactoryIdentity;
        else
          return new Quaternion<Fraction128>(right.X, right.Y, right.Z, right.W);
      }
      else if (LinearAlgebra.MagnitudeSquared(right) == 0)
        return new Quaternion<Fraction128>(left.X, left.Y, left.Z, left.W);
      Fraction128 cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      if (cosHalfAngle >= 1 || cosHalfAngle <= -1)
        return new Quaternion<Fraction128>(left.X, left.Y, left.Z, left.W);
      else if (cosHalfAngle < 0)
      {
        right = new Quaternion<Fraction128>(-left.X, -left.Y, -left.Z, -left.W);
        cosHalfAngle = -cosHalfAngle;
      }
      Fraction128 halfAngle = Trigonometry.arccos(cosHalfAngle);
      Fraction128 sinHalfAngle = Trigonometry.sin(halfAngle);
      Fraction128 blendA = Trigonometry.sin(halfAngle * (1 - blend)) / sinHalfAngle;
      Fraction128 blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      Quaternion<Fraction128> result = new Quaternion<Fraction128>(
        blendA * left.X + blendB * right.X,
        blendA * left.Y + blendB * right.Y,
        blendA * left.Z + blendB * right.Z,
        blendA * left.W + blendB * right.W);
      if (LinearAlgebra.MagnitudeSquared(result) > 0)
        return LinearAlgebra.Normalize(result);
      else
        return Quaternion<Fraction128>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<Fraction128> Rotate(Quaternion<Fraction128> rotation, Vector<Fraction128> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<Fraction128> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<Fraction128>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<Fraction128> left, Quaternion<Fraction128> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<Fraction128> left, Quaternion<Fraction128> right, Fraction128 leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #region Fraction64

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static Fraction64[] Add(Fraction64[] left, Fraction64[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      Fraction64[] result = new Fraction64[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static Fraction64[] Negate(Fraction64[] vector)
    {
      Fraction64[] result = new Fraction64[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static Fraction64[] Subtract(Fraction64[] left, Fraction64[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      Fraction64[] result = new Fraction64[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static Fraction64[] Multiply(Fraction64[] left, Fraction64 right)
    {
      Fraction64[] result = new Fraction64[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static Fraction64[] Divide(Fraction64[] vector, Fraction64 right)
    {
      Fraction64[] result = new Fraction64[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static Fraction64 DotProduct(Fraction64[] left, Fraction64[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      Fraction64 result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static Fraction64[] CrossProduct(Fraction64[] left, Fraction64[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new Fraction64[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static Fraction64[] Normalize(Fraction64[] vector)
    {
      Fraction64 length = LinearAlgebra.Magnitude(vector);
      if (length != 0)
      {
        Fraction64[] result = new Fraction64[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new Fraction64[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static Fraction64 Magnitude(Fraction64[] vector)
    {
      Fraction64 result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (Fraction64)System.Math.Sqrt((double)result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static Fraction64 MagnitudeSquared(Fraction64[] vector)
    {
      Fraction64 result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static Fraction64 Angle(Fraction64[] first, Fraction64[] second)
    {
      return (Fraction64)System.Math.Acos((double)(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second))));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static Fraction64[] RotateBy(Fraction64[] vector, Fraction64 angle, Fraction64 x, Fraction64 y, Fraction64 z)
    {
      if (vector.Length == 3)
      {
        // Note: the angle is in radians
        Fraction64 sinHalfAngle = (Fraction64)System.Math.Sin((double)angle / 2d);
        Fraction64 cosHalfAngle = (Fraction64)System.Math.Cos((double)angle / 2d);
        x *= sinHalfAngle;
        y *= sinHalfAngle;
        z *= sinHalfAngle;
        Fraction64 x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
        Fraction64 y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
        Fraction64 z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
        Fraction64 w2 = -x * vector[0] - y * vector[1] - z * vector[2];
        return new Fraction64[] {
          x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
          y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
          z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      }
      throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static Fraction64[] RotateBy(Fraction64[] vector, Quaternion<Fraction64> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Fraction64[] Lerp(Fraction64[] left, Fraction64[] right, Fraction64 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      Fraction64[] result = new Fraction64[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static Fraction64[] Slerp(Fraction64[] left, Fraction64[] right, Fraction64 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      Fraction64 dot = LinearAlgebra.DotProduct(left, right);
      dot = dot < -1 ? -1 : dot;
      dot = dot > 1 ? 1 : dot;
      Fraction64 theta = (Fraction64)System.Math.Acos((double)dot) * blend;
      return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, (Fraction64)System.Math.Cos((double)theta)),
        LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), (Fraction64)System.Math.Sin((double)theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static Fraction64[] Blerp(Fraction64[] a, Fraction64[] b, Fraction64[] c, Fraction64 u, Fraction64 v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction64[] left, Fraction64[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction64[] left, Fraction64[] right, Fraction64 leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static Fraction64[,] MatrixFactoryIdentity_Fraction64(int rows, int columns)
    {
      Fraction64[,] matrix;
      try { matrix = new Fraction64[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(Fraction64[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Fraction64[,] Negate(Fraction64[,] matrix)
    {
      Fraction64[,] result = new Fraction64[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static Fraction64[,] Add(Fraction64[,] left, Fraction64[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      Fraction64[,] result = new Fraction64[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static Fraction64[,] Subtract(Fraction64[,] left, Fraction64[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      Fraction64[,] result = new Fraction64[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction64[,] Multiply(Fraction64[,] left, Fraction64[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      Fraction64[,] result = new Fraction64[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction64[] Multiply(Fraction64[,] left, Fraction64[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      Fraction64[] result = new Fraction64[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j] * right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Fraction64[,] Multiply(Fraction64[,] left, Fraction64 right)
    {
      Fraction64[,] result = new Fraction64[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static Fraction64[,] Power(Fraction64[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_Fraction64(matrix.GetLength(0), matrix.GetLength(1));
      Fraction64[,] result = matrix.Clone() as Fraction64[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static Fraction64[,] Divide(Fraction64[,] matrix, Fraction64 right)
    {
      Fraction64[,] result = new Fraction64[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static Fraction64[,] Minor(Fraction64[,] matrix, int row, int column)
    {
      Fraction64[,] minor = new Fraction64[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static Fraction64[,] ConcatenateRowWise(Fraction64[,] left, Fraction64[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      Fraction64[,] result = new Fraction64[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static Fraction64[,] Echelon(Fraction64[,] matrix)
    {
      try
      {
        Fraction64[,] result = matrix.Clone() as Fraction64[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static Fraction64[,] ReducedEchelon(Fraction64[,] matrix)
    {
      try
      {
        Fraction64[,] result = matrix.Clone() as Fraction64[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch (Error e) { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static Fraction64 Determinent(Fraction64[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        Fraction64 det = 1;
        Fraction64[,] rref = matrix.Clone() as Fraction64[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static Fraction64[,] Inverse(Fraction64[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        Fraction64[,] identity = LinearAlgebra.MatrixFactoryIdentity_Fraction64(matrix.GetLength(0), matrix.GetLength(1));
        Fraction64[,] rref = matrix.Clone() as Fraction64[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static Fraction64[,] Adjoint(Fraction64[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      Fraction64[,] AdjointMatrix = new Fraction64[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static Fraction64[,] Transpose(Fraction64[,] matrix)
    {
      Fraction64[,] transpose = new Fraction64[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(Fraction64[,] matrix, out Fraction64[,] Lower, out Fraction64[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_Fraction64(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as Fraction64[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      Fraction64 p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static Fraction64[,] Clone(Fraction64[,] matrix)
    {
      Fraction64[,] result = new Fraction64[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(Fraction64[,] matrix, int row, Fraction64 scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(Fraction64[,] matrix, int target, int second, Fraction64 scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(Fraction64[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Fraction64 temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction64[,] left, Fraction64[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Fraction64[,] left, Fraction64[,] right, Fraction64 leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static Fraction64 Magnitude(Quaternion<Fraction64> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static Fraction64 MagnitudeSquared(Quaternion<Fraction64> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<Fraction64> Conjugate(Quaternion<Fraction64> quaternion)
    {
      return new Quaternion<Fraction64>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<Fraction64> Add(Quaternion<Fraction64> left, Quaternion<Fraction64> right)
    {
      return new Quaternion<Fraction64>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<Fraction64> Subtract(Quaternion<Fraction64> left, Quaternion<Fraction64> right)
    {
      return new Quaternion<Fraction64>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<Fraction64> Multiply(Quaternion<Fraction64> left, Quaternion<Fraction64> right)
    {
      return new Quaternion<Fraction64>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<Fraction64> Multiply(Quaternion<Fraction64> left, Fraction64 right)
    {
      return new Quaternion<Fraction64>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<Fraction64> Multiply(Quaternion<Fraction64> left, Vector<Fraction64> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<Fraction64>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<Fraction64> Normalize(Quaternion<Fraction64> quaternion)
    {
      Fraction64 normalizer = Quaternion<Fraction64>.Magnitude(quaternion);
      if (normalizer != 0)
        return quaternion * (1 / normalizer);
      else
        return Quaternion<Fraction64>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<Fraction64> Invert(Quaternion<Fraction64> quaternion)
    {
      Fraction64 normalizer = Quaternion<Fraction64>.MagnitudeSquared(quaternion);
      if (normalizer == 0)
        return new Quaternion<Fraction64>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1 / normalizer;
      return new Quaternion<Fraction64>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<Fraction64> Lerp(Quaternion<Fraction64> left, Quaternion<Fraction64> right, Fraction64 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (Quaternion<Fraction64>.MagnitudeSquared(left) == 0)
      {
        if (Quaternion<Fraction64>.MagnitudeSquared(right) == 0)
          return Quaternion<Fraction64>.FactoryIdentity;
        else
          return new Quaternion<Fraction64>(right.X, right.Y, right.Z, right.W);
      }
      else if (Quaternion<Fraction64>.MagnitudeSquared(right) == 0)
        return new Quaternion<Fraction64>(left.X, left.Y, left.Z, left.W);
      Quaternion<Fraction64> result = new Quaternion<Fraction64>(
        1 - blend * left.X + blend * right.X,
        1 - blend * left.Y + blend * right.Y,
        1 - blend * left.Z + blend * right.Z,
        1 - blend * left.W + blend * right.W);
      if (Quaternion<Fraction64>.MagnitudeSquared(result) > 0)
        return Quaternion<Fraction64>.Normalize(result);
      else
        return Quaternion<Fraction64>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<Fraction64> Slerp(Quaternion<Fraction64> left, Quaternion<Fraction64> right, Fraction64 blend)
    {
      if (blend < 0 || blend > 1)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (LinearAlgebra.MagnitudeSquared(left) == 0)
      {
        if (LinearAlgebra.MagnitudeSquared(right) == 0)
          return Quaternion<Fraction64>.FactoryIdentity;
        else
          return new Quaternion<Fraction64>(right.X, right.Y, right.Z, right.W);
      }
      else if (LinearAlgebra.MagnitudeSquared(right) == 0)
        return new Quaternion<Fraction64>(left.X, left.Y, left.Z, left.W);
      Fraction64 cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      if (cosHalfAngle >= 1 || cosHalfAngle <= -1)
        return new Quaternion<Fraction64>(left.X, left.Y, left.Z, left.W);
      else if (cosHalfAngle < 0)
      {
        right = new Quaternion<Fraction64>(-left.X, -left.Y, -left.Z, -left.W);
        cosHalfAngle = -cosHalfAngle;
      }
      Fraction64 halfAngle = Trigonometry.arccos(cosHalfAngle);
      Fraction64 sinHalfAngle = Trigonometry.sin(halfAngle);
      Fraction64 blendA = Trigonometry.sin(halfAngle * (1 - blend)) / sinHalfAngle;
      Fraction64 blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      Quaternion<Fraction64> result = new Quaternion<Fraction64>(
        blendA * left.X + blendB * right.X,
        blendA * left.Y + blendB * right.Y,
        blendA * left.Z + blendB * right.Z,
        blendA * left.W + blendB * right.W);
      if (LinearAlgebra.MagnitudeSquared(result) > 0)
        return LinearAlgebra.Normalize(result);
      else
        return Quaternion<Fraction64>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<Fraction64> Rotate(Quaternion<Fraction64> rotation, Vector<Fraction64> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<Fraction64> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<Fraction64>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<Fraction64> left, Quaternion<Fraction64> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<Fraction64> left, Quaternion<Fraction64> right, Fraction64 leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #region decimal

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static decimal[] Add(decimal[] left, decimal[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      decimal[] result = new decimal[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static decimal[] Negate(decimal[] vector)
    {
      decimal[] result = new decimal[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static decimal[] Subtract(decimal[] left, decimal[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      decimal[] result = new decimal[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static decimal[] Multiply(decimal[] left, decimal right)
    {
      decimal[] result = new decimal[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static decimal[] Divide(decimal[] vector, decimal right)
    {
      decimal[] result = new decimal[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static decimal DotProduct(decimal[] left, decimal[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      decimal result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static decimal[] CrossProduct(decimal[] left, decimal[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new decimal[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static decimal[] Normalize(decimal[] vector)
    {
      decimal length = LinearAlgebra.Magnitude(vector);
      if (length != 0.0M)
      {
        decimal[] result = new decimal[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new decimal[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static decimal Magnitude(decimal[] vector)
    {
      decimal result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (decimal)System.Math.Sqrt((double)result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static decimal MagnitudeSquared(decimal[] vector)
    {
      decimal result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static decimal Angle(decimal[] first, decimal[] second)
    {
      return (decimal)System.Math.Acos((double)(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second))));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static decimal[] RotateBy(decimal[] vector, decimal angle, decimal x, decimal y, decimal z)
    {
      if (vector.Length == 3)
      {
        // Note: the angle is in radians
        decimal sinHalfAngle = (decimal)System.Math.Sin((double)angle / 2d);
        decimal cosHalfAngle = (decimal)System.Math.Cos((double)angle / 2d);
        x *= sinHalfAngle;
        y *= sinHalfAngle;
        z *= sinHalfAngle;
        decimal x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
        decimal y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
        decimal z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
        decimal w2 = -x * vector[0] - y * vector[1] - z * vector[2];
        return new decimal[] {
          x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
          y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
          z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      }
      throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static decimal[] RotateBy(decimal[] vector, Quaternion<decimal> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static decimal[] Lerp(decimal[] left, decimal[] right, decimal blend)
    {
      if (blend < 0 || blend > 1.0M)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      decimal[] result = new decimal[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static decimal[] Slerp(decimal[] left, decimal[] right, decimal blend)
    {
      if (blend < 0 || blend > 1.0M)
        throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      decimal dot = LinearAlgebra.DotProduct(left, right);
      dot = dot < -1.0M ? -1.0M : dot;
      dot = dot > 1.0M ? 1.0M : dot;
      decimal theta = (decimal)System.Math.Acos((double)dot) * blend;
      return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, (decimal)System.Math.Cos((double)theta)),
        LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), (decimal)System.Math.Sin((double)theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static decimal[] Blerp(decimal[] a, decimal[] b, decimal[] c, decimal u, decimal v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(decimal[] left, decimal[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(decimal[] left, decimal[] right, decimal leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static decimal[,] MatrixFactoryIdentity_decimal(int rows, int columns)
    {
      decimal[,] matrix;
      try { matrix = new decimal[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(decimal[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static decimal[,] Negate(decimal[,] matrix)
    {
      decimal[,] result = new decimal[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static decimal[,] Add(decimal[,] left, decimal[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      decimal[,] result = new decimal[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static decimal[,] Subtract(decimal[,] left, decimal[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      decimal[,] result = new decimal[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static decimal[,] Multiply(decimal[,] left, decimal[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      decimal[,] result = new decimal[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static decimal[] Multiply(decimal[,] left, decimal[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      decimal[] result = new decimal[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j]* right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static decimal[,] Multiply(decimal[,] left, decimal right)
    {
      decimal[,] result = new decimal[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static decimal[,] Power(decimal[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_decimal(matrix.GetLength(0), matrix.GetLength(1));
      decimal[,] result = matrix.Clone() as decimal[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static decimal[,] Divide(decimal[,] matrix, decimal right)
    {
      decimal[,] result = new decimal[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static decimal[,] Minor(decimal[,] matrix, int row, int column)
    {
      decimal[,] minor = new decimal[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static decimal[,] ConcatenateRowWise(decimal[,] left, decimal[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      decimal[,] result = new decimal[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static decimal[,] Echelon(decimal[,] matrix)
    {
      try
      {
        decimal[,] result = matrix.Clone() as decimal[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static decimal[,] ReducedEchelon(decimal[,] matrix)
    {
      try
      {
        decimal[,] result = matrix.Clone() as decimal[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static decimal Determinent(decimal[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        decimal det = 1.0M;
        decimal[,] rref = matrix.Clone() as decimal[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static decimal[,] Inverse(decimal[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        decimal[,] identity = LinearAlgebra.MatrixFactoryIdentity_decimal(matrix.GetLength(0), matrix.GetLength(1));
        decimal[,] rref = matrix.Clone() as decimal[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static decimal[,] Adjoint(decimal[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      decimal[,] AdjointMatrix = new decimal[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static decimal[,] Transpose(decimal[,] matrix)
    {
      decimal[,] transpose = new decimal[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(decimal[,] matrix, out decimal[,] Lower, out decimal[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_decimal(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as decimal[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      decimal p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static decimal[,] Clone(decimal[,] matrix)
    {
      decimal[,] result = new decimal[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(decimal[,] matrix, int row, decimal scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(decimal[,] matrix, int target, int second, decimal scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(decimal[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        decimal temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(decimal[,] left, decimal[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(decimal[,] left, decimal[,] right, decimal leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static decimal Magnitude(Quaternion<decimal> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static decimal MagnitudeSquared(Quaternion<decimal> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<decimal> Conjugate(Quaternion<decimal> quaternion)
    {
      return new Quaternion<decimal>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<decimal> Add(Quaternion<decimal> left, Quaternion<decimal> right)
    {
      return new Quaternion<decimal>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<decimal> Subtract(Quaternion<decimal> left, Quaternion<decimal> right)
    {
      return new Quaternion<decimal>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<decimal> Multiply(Quaternion<decimal> left, Quaternion<decimal> right)
    {
      return new Quaternion<decimal>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<decimal> Multiply(Quaternion<decimal> left, decimal right)
    {
      return new Quaternion<decimal>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<decimal> Multiply(Quaternion<decimal> left, Vector<decimal> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<decimal>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<decimal> Normalize(Quaternion<decimal> quaternion)
    {
      decimal normalizer = Quaternion<decimal>.Magnitude(quaternion);
      if (normalizer != 0M)
        return quaternion * (1M / normalizer);
      else
        return Quaternion<decimal>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<decimal> Invert(Quaternion<decimal> quaternion)
    {
      decimal normalizer = Quaternion<decimal>.MagnitudeSquared(quaternion);
      if (normalizer == 0M)
        return new Quaternion<decimal>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1M / normalizer;
      return new Quaternion<decimal>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<decimal> Lerp(Quaternion<decimal> left, Quaternion<decimal> right, decimal blend)
    {
      if (blend < 0M || blend > 1M)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (Quaternion<decimal>.MagnitudeSquared(left) == 0M)
      {
        if (Quaternion<decimal>.MagnitudeSquared(right) == 0M)
          return Quaternion<decimal>.FactoryIdentity;
        else
          return new Quaternion<decimal>(right.X, right.Y, right.Z, right.W);
      }
      else if (Quaternion<decimal>.MagnitudeSquared(right) == 0M)
        return new Quaternion<decimal>(left.X, left.Y, left.Z, left.W);
      Quaternion<decimal> result = new Quaternion<decimal>(
        1M - blend * left.X + blend * right.X,
        1M - blend * left.Y + blend * right.Y,
        1M - blend * left.Z + blend * right.Z,
        1M - blend * left.W + blend * right.W);
      if (Quaternion<decimal>.MagnitudeSquared(result) > 0M)
        return Quaternion<decimal>.Normalize(result);
      else
        return Quaternion<decimal>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<decimal> Slerp(Quaternion<decimal> left, Quaternion<decimal> right, decimal blend)
    {
      if (blend < 0M || blend > 1M)
      	throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (LinearAlgebra.MagnitudeSquared(left) == 0M)
      {
      	if (LinearAlgebra.MagnitudeSquared(right) == 0M)
      		return Quaternion<decimal>.FactoryIdentity;
      	else
      		return new Quaternion<decimal>(right.X, right.Y, right.Z, right.W);
      }
      else if (LinearAlgebra.MagnitudeSquared(right) ==  0M)
      	return new Quaternion<decimal>(left.X, left.Y, left.Z, left.W);
      decimal cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      if (cosHalfAngle >= 1.0M || cosHalfAngle <= -1.0M)
      	return new Quaternion<decimal>(left.X, left.Y, left.Z, left.W);
      else if (cosHalfAngle < 0.0M)
      {
      	right = new Quaternion<decimal>(-left.X, -left.Y, -left.Z, -left.W);
      	cosHalfAngle = -cosHalfAngle;
      }
      decimal halfAngle = Trigonometry.arccos(cosHalfAngle);
      decimal sinHalfAngle = Trigonometry.sin(halfAngle);
      decimal blendA = Trigonometry.sin(halfAngle * (1M - blend)) / sinHalfAngle;
      decimal blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      Quaternion<decimal> result = new Quaternion<decimal>(
      	blendA * left.X + blendB * right.X,
      	blendA * left.Y + blendB * right.Y,
      	blendA * left.Z + blendB * right.Z,
      	blendA * left.W + blendB * right.W);
      if (LinearAlgebra.MagnitudeSquared(result) > 0M)
      	return LinearAlgebra.Normalize(result);
      else
      	return Quaternion<decimal>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<decimal> Rotate(Quaternion<decimal> rotation, Vector<decimal> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<decimal> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<decimal>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<decimal> left, Quaternion<decimal> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<decimal> left, Quaternion<decimal> right, decimal leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #region double

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static double[] Add(double[] left, double[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      double[] result = new double[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static double[] Negate(double[] vector)
    {
      double[] result = new double[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static double[] Subtract(double[] left, double[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      double[] result = new double[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static double[] Multiply(double[] left, double right)
    {
      double[] result = new double[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static double[] Divide(double[] vector, double right)
    {
      double[] result = new double[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static double DotProduct(double[] left, double[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      double result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static double[] CrossProduct(double[] left, double[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new double[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static double[] Normalize(double[] vector)
    {
      double length = LinearAlgebra.Magnitude(vector);
      if (length != 0.0)
      {
        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new double[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static double Magnitude(double[] vector)
    {
      double result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return System.Math.Sqrt(result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static double MagnitudeSquared(double[] vector)
    {
      double result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static double Angle(double[] first, double[] second)
    {
      return System.Math.Acos(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second)));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static double[] RotateBy(double[] vector, double angle, double x, double y, double z)
    {
      if (vector.Length == 3)
      {
        // Note: the angle is in radians
        double sinHalfAngle = System.Math.Sin(angle / 2);
        double cosHalfAngle = System.Math.Cos(angle / 2);
        x *= sinHalfAngle;
        y *= sinHalfAngle;
        z *= sinHalfAngle;
        double x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
        double y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
        double z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
        double w2 = -x * vector[0] - y * vector[1] - z * vector[2];
        return new double[] {
          x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
          y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
          z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      }
      throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static double[] RotateBy(double[] vector, Quaternion<double> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static double[] Lerp(double[] left, double[] right, double blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      double[] result = new double[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static double[] Slerp(double[] left, double[] right, double blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      double dot = LinearAlgebra.DotProduct(left, right);
      dot = dot < -1.0d ? -1.0d : dot;
      dot = dot > 1.0d ? 1.0 : dot;
      double theta = System.Math.Acos(dot) * blend;
      return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, System.Math.Cos(theta)), 
        LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), System.Math.Sin(theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static double[] Blerp(double[] a, double[] b, double[] c, double u, double v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u), 
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(double[] left, double[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(double[] left, double[] right, double leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(double[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
		/// <param name="rows">The number of rows of the matrix.</param>
		/// <param name="columns">The number of columns of the matrix.</param>
		/// <returns>The newly constructed identity-matrix.</returns>
		public static double[,] MatrixFactoryIdentity_double(int rows, int columns)
		{
			double[,] matrix;
			try { matrix = new double[rows, columns]; }
			catch { throw new Error("invalid dimensions."); }
			if (rows <= columns)
				for (int i = 0; i < rows; i++)
					matrix[i, i] = 1;
			else
				for (int i = 0; i < columns; i++)
					matrix[i, i] = 1;
			return matrix;
		}

		/// <summary>Negates all the values in a matrix.</summary>
		/// <param name="matrix">The matrix to have its values negated.</param>
		/// <returns>The resulting matrix after the negations.</returns>
		public static double[,] Negate(double[,] matrix)
		{
      int matrix_row = matrix.GetLength(0);
      int matrix_col = matrix.GetLength(1);

			double[,] result = new double[matrix_row, matrix_col];
      for (int i = 0; i < matrix_row; i++)
        for (int j = 0; j < matrix_col; j++)
					result[i, j] = -matrix[i, j];
			return result;
		}

		/// <summary>Does standard addition of two matrices.</summary>
		/// <param name="left">The left matrix of the addition.</param>
		/// <param name="right">The right matrix of the addition.</param>
		/// <returns>The resulting matrix after the addition.</returns>
		public static double[,] Add(double[,] left, double[,] right)
		{
      int left_row = left.GetLength(0);
      int left_col = left.GetLength(1);

			if (left_row != right.GetLength(0) || left_col != right.GetLength(1))
				throw new Error("invalid addition (size miss-match).");

			double[,] result = new double[left_row, left_col];
			for (int i = 0; i < left_row; i++)
				for (int j = 0; j < left_col; j++)
					result[i, j] = left[i, j] + right[i, j];
			return result;
		}

		/// <summary>Subtracts a scalar from all the values in a matrix.</summary>
		/// <param name="left">The matrix to have the values subtracted from.</param>
		/// <param name="right">The scalar to subtract from all the matrix values.</param>
		/// <returns>The resulting matrix after the subtractions.</returns>
		public static double[,] Subtract(double[,] left, double[,] right)
		{
      int left_row = left.GetLength(0);
      int left_col = left.GetLength(1);
      
			if (left_row != right.GetLength(0) || left_col != right.GetLength(1))
				throw new Error("invalid subtraction (size miss-match).");

			double[,] result = new double[left_row, left_col];
			for (int i = 0; i < left_row; i++)
				for (int j = 0; j < left_col; j++)
					result[i, j] = left[i, j] - right[i, j];
			return result;
		}

		/// <summary>Performs multiplication on two matrices.</summary>
		/// <param name="left">The left matrix of the multiplication.</param>
		/// <param name="right">The right matrix of the multiplication.</param>
		/// <returns>The resulting matrix of the multiplication.</returns>
		public static double[,] Multiply(double[,] left, double[,] right)
		{
      int left_row = left.GetLength(0);
      int left_col = left.GetLength(1);
      int right_col = right.GetLength(1);

      if (left_col != right.GetLength(0))
				throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");

			double[,] result = new double[left_row, right_col];
			for (int i = 0; i < left_row; i++)
				for (int j = 0; j < right_col; j++)
					for (int k = 0; k < left_col; k++)
						result[i, j] += left[i, k] * right[k, j];
			return result;
		}

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static double[] Multiply(double[,] left, double[] right)
    {
      int left_row = left.GetLength(0);
      int left_col = left.GetLength(1);

      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      double[] result = new double[left.GetLength(1)];
      for (int i = 0; i < left_row; i++)
        for (int j = 0; j < left_col; j++)
          result[i] += + left[i, j] * right[j];
      return result;
    }

		/// <summary>Multiplies all the values in a matrix by a scalar.</summary>
		/// <param name="left">The matrix to have the values multiplied.</param>
		/// <param name="right">The scalar to multiply the values by.</param>
		/// <returns>The resulting matrix after the multiplications.</returns>
		public static double[,] Multiply(double[,] left, double right)
		{
      int left_row = left.GetLength(0);
      int left_col = left.GetLength(1);

			double[,] result = new double[left_row, left_col];
			for (int i = 0; i < left_row; i++)
				for (int j = 0; j < left_col; j++)
					result[i, j] = left[i, j] * right;
			return result;
		}

		/// <summary>Applies a power to a square matrix.</summary>
		/// <param name="matrix">The matrix to be powered by.</param>
		/// <param name="power">The power to apply to the matrix.</param>
		/// <returns>The resulting matrix of the power operation.</returns>
		public static double[,] Power(double[,] matrix, int power)
		{
			if (!(matrix.GetLength(0) == matrix.GetLength(1)))
				throw new Error("invalid power (!matrix.IsSquare).");
			if (!(power >= 0))
				throw new Error("invalid power !(power > -1)");
			if (power == 0)
				return LinearAlgebra.MatrixFactoryIdentity_double(matrix.GetLength(0), matrix.GetLength(1));
			double[,] result = matrix.Clone() as double[,];
			for (int i = 0; i < power; i++)
				result = LinearAlgebra.Multiply(result, result);
			return result;
		}

		/// <summary>Divides all the values in the matrix by a scalar.</summary>
		/// <param name="matrix">The matrix to divide the values of.</param>
		/// <param name="right">The scalar to divide all the matrix values by.</param>
		/// <returns>The resulting matrix with the divided values.</returns>
		public static double[,] Divide(double[,] matrix, double right)
		{
      int matrix_row = matrix.GetLength(0);
      int matrix_col = matrix.GetLength(1);

      double[,] result = new double[matrix_row, matrix_col];
      for (int i = 0; i < matrix_row; i++)
        for (int j = 0; j < matrix_col; j++)
					result[i, j] = matrix[i, j] / right;
			return result;
		}

		/// <summary>Gets the minor of a matrix.</summary>
		/// <param name="matrix">The matrix to get the minor of.</param>
		/// <param name="row">The restricted row to form the minor.</param>
		/// <param name="column">The restricted column to form the minor.</param>
		/// <returns>The minor of the matrix.</returns>
		public static double[,] Minor(double[,] matrix, int row, int column)
		{
			double[,] minor = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
			int m = 0, n = 0;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (i == row) continue;
				n = 0;
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (j == column) continue;
					minor[m, n] = matrix[i, j];
					n++;
				}
				m++;
			}
			return minor;
		}

		/// <summary>Combines two matrices from left to right 
		/// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
		/// <param name="left">The left matrix of the concatenation.</param>
		/// <param name="right">The right matrix of the concatenation.</param>
		/// <returns>The resulting matrix of the concatenation.</returns>
		public static double[,] ConcatenateRowWise(double[,] left, double[,] right)
		{
			if (left.GetLength(0) != right.GetLength(0))
				throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
			double[,] result = new double[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
			for (int i = 0; i < result.GetLength(0); i++)
				for (int j = 0; j < result.GetLength(1); j++)
				{
					if (j < left.GetLength(1)) result[i, j] = left[i, j];
					else result[i, j] = right[i, j - left.GetLength(1)];
				}
			return result;
		}

		/// <summary>Calculates the echelon of a matrix (aka REF).</summary>
		/// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
		/// <returns>The echelon of the matrix (aka REF).</returns>
		public static double[,] Echelon(double[,] matrix)
		{
			try
			{
				double[,] result = matrix.Clone() as double[,];
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (result[i, i] == 0)
						for (int j = i + 1; j < result.GetLength(0); j++)
							if (result[j, i] != 0)
								LinearAlgebra.SwapRows(result, i, j);
					if (result[i, i] == 0)
						continue;
					if (result[i, i] != 1)
						for (int j = i + 1; j < result.GetLength(0); j++)
							if (result[j, i] == 1)
								LinearAlgebra.SwapRows(result, i, j);
					LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
					for (int j = i + 1; j < result.GetLength(0); j++)
						LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
				}
				return result;
			}
			catch { throw new Error("echelon computation failed."); }
		}

		/// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
		/// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
		/// <returns>The reduced echelon of the matrix (aka RREF).</returns>
		public static double[,] ReducedEchelon(double[,] matrix)
		{
			try
			{
				double[,] result = matrix.Clone() as double[,];
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (result[i, i] == 0)
						for (int j = i + 1; j < result.GetLength(0); j++)
							if (result[j, i] != 0)
								LinearAlgebra.SwapRows(result, i, j);
					if (result[i, i] == 0) continue;
					if (result[i, i] != 1)
						for (int j = i + 1; j < result.GetLength(0); j++)
							if (result[j, i] == 1)
								LinearAlgebra.SwapRows(result, i, j);
					LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
					for (int j = i + 1; j < result.GetLength(0); j++)
						LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
					for (int j = i - 1; j >= 0; j--)
						LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
				}
				return result;
			}
			catch { throw new Error("reduced echelon calculation failed."); }
		}

		/// <summary>Calculates the determinent of a square matrix.</summary>
		/// <param name="matrix">The matrix to calculate the determinent of.</param>
		/// <returns>The determinent of the matrix.</returns>
		public static double Determinent(double[,] matrix)
		{
			if (!(matrix.GetLength(0) == matrix.GetLength(1)))
				throw new Error("invalid determinent !(matrix.IsSquare).");
			try
			{
				double det = 1.0f;
				double[,] rref = matrix.Clone() as double[,];
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (rref[i, i] == 0)
						for (int j = i + 1; j < rref.GetLength(0); j++)
							if (rref[j, i] != 0)
							{
								LinearAlgebra.SwapRows(rref, i, j);
								det *= -1;
							}
					det *= rref[i, i];
					LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
					for (int j = i + 1; j < rref.GetLength(0); j++)
						LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
					for (int j = i - 1; j >= 0; j--)
						LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
				}
				return det;
			}
			catch { throw new Error("determinent computation failed."); }
		}

		/// <summary>Calculates the inverse of a matrix.</summary>
		/// <param name="matrix">The matrix to calculate the inverse of.</param>
		/// <returns>The inverse of the matrix.</returns>
		public static double[,] Inverse(double[,] matrix)
		{
			if (LinearAlgebra.Determinent(matrix) == 0)
				throw new Error("inverse calculation failed.");
			try
			{
				double[,] identity = LinearAlgebra.MatrixFactoryIdentity_double(matrix.GetLength(0), matrix.GetLength(1));
				double[,] rref = matrix.Clone() as double[,];
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (rref[i, i] == 0)
						for (int j = i + 1; j < rref.GetLength(0); j++)
							if (rref[j, i] != 0)
							{
								LinearAlgebra.SwapRows(rref, i, j);
								LinearAlgebra.SwapRows(identity, i, j);
							}
					LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
					LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
					for (int j = i + 1; j < rref.GetLength(0); j++)
					{
						LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
						LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
					}
					for (int j = i - 1; j >= 0; j--)
					{
						LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
						LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
					}
				}
				return identity;
			}
			catch { throw new Error("inverse calculation failed."); }
		}

		/// <summary>Calculates the adjoint of a matrix.</summary>
		/// <param name="matrix">The matrix to calculate the adjoint of.</param>
		/// <returns>The adjoint of the matrix.</returns>
		public static double[,] Adjoint(double[,] matrix)
		{
			if (!(matrix.GetLength(0) == matrix.GetLength(1)))
				throw new Error("Adjoint of a non-square matrix does not exists");
			double[,] AdjointMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
			for (int i = 0; i < matrix.GetLength(0); i++)
				for (int j = 0; j < matrix.GetLength(1); j++)
					if ((i + j) % 2 == 0)
						AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
					else
						AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
			return LinearAlgebra.Transpose(AdjointMatrix);
		}

		/// <summary>Returns the transpose of a matrix.</summary>
		/// <param name="matrix">The matrix to transpose.</param>
		/// <returns>The transpose of the matrix.</returns>
		public static double[,] Transpose(double[,] matrix)
		{
			double[,] transpose = new double[matrix.GetLength(1), matrix.GetLength(0)];
			for (int i = 0; i < transpose.GetLength(0); i++)
				for (int j = 0; j < transpose.GetLength(1); j++)
					transpose[i, j] = matrix[j, i];
			return transpose;
		}

		/// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
		/// <param name="matrix">The matrix to decompose.</param>
		/// <param name="Lower">The computed lower triangular matrix.</param>
		/// <param name="Upper">The computed upper triangular matrix.</param>
		public static void DecomposeLU(double[,] matrix, out double[,] Lower, out double[,] Upper)
		{
			if (!(matrix.GetLength(0) == matrix.GetLength(1)))
				throw new Error("The matrix is not square!");
			Lower = LinearAlgebra.MatrixFactoryIdentity_double(matrix.GetLength(0), matrix.GetLength(1));
			Upper = matrix.Clone() as double[,];
			int[] permutation = new int[matrix.GetLength(0)];
			for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
			double p = 0, pom2, detOfP = 1;
			int k0 = 0, pom1 = 0;
			for (int k = 0; k < matrix.GetLength(1) - 1; k++)
			{
				p = 0;
				for (int i = k; i < matrix.GetLength(0); i++)
					if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
					{
						p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
						k0 = i;
					}
				if (p == 0)
					throw new Error("The matrix is singular!");
				pom1 = permutation[k];
				permutation[k] = permutation[k0];
				permutation[k0] = pom1;
				for (int i = 0; i < k; i++)
				{
					pom2 = Lower[k, i];
					Lower[k, i] = Lower[k0, i];
					Lower[k0, i] = pom2;
				}
				if (k != k0)
					detOfP *= -1;
				for (int i = 0; i < matrix.GetLength(1); i++)
				{
					pom2 = Upper[k, i];
					Upper[k, i] = Upper[k0, i];
					Upper[k0, i] = pom2;
				}
				for (int i = k + 1; i < matrix.GetLength(0); i++)
				{
					Lower[i, k] = Upper[i, k] / Upper[k, k];
					for (int j = k; j < matrix.GetLength(1); j++)
						Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
				}
			}
		}

		/// <summary>Creates a copy of a matrix.</summary>
		/// <param name="matrix">The matrix to copy.</param>
		/// <returns>A copy of the matrix.</returns>
		public static double[,] Clone(double[,] matrix)
		{
			double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
			for (int i = 0; i < matrix.GetLength(0); i++)
				for (int j = 0; j < matrix.GetLength(1); j++)
					result[i, j] = matrix[i, j];
			return result;
		}

		private static void RowMultiplication(double[,] matrix, int row, double scalar)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				matrix[row, j] *= scalar;
		}

		private static void RowAddition(double[,] matrix, int target, int second, double scalar)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				matrix[target, j] += (matrix[second, j] * scalar);
		}

		private static void SwapRows(double[,] matrix, int row1, int row2)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				double temp = matrix[row1, j];
				matrix[row1, j] = matrix[row2, j];
				matrix[row2, j] = temp;
			}
		}

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(double[,] left, double[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(double[,] left, double[,] right, double leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static double Magnitude(Quaternion<double> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static double MagnitudeSquared(Quaternion<double> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<double> Conjugate(Quaternion<double> quaternion)
    {
      return new Quaternion<double>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<double> Add(Quaternion<double> left, Quaternion<double> right)
    {
      return new Quaternion<double>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<double> Subtract(Quaternion<double> left, Quaternion<double> right)
    {
      return new Quaternion<double>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<double> Multiply(Quaternion<double> left, Quaternion<double> right)
    {
      return new Quaternion<double>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<double> Multiply(Quaternion<double> left, double right)
    {
      return new Quaternion<double>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<double> Multiply(Quaternion<double> left, Vector<double> right)
    {
      if (right.Dimensions == 3 || right.Dimensions == 4)
      {
        return new Quaternion<double>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<double> Normalize(Quaternion<double> quaternion)
    {
      double normalizer = Quaternion<double>.Magnitude(quaternion);
      if (normalizer != 0d)
        return quaternion * (1d / normalizer);
      else
        return Quaternion<double>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<double> Invert(Quaternion<double> quaternion)
    {
      double normalizer = Quaternion<double>.MagnitudeSquared(quaternion);
      if (normalizer == 0d)
        return new Quaternion<double>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1d / normalizer;
      return new Quaternion<double>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<double> Lerp(Quaternion<double> left, Quaternion<double> right, double blend)
    {
      if (blend < 0d || blend > 1d)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (Quaternion<double>.MagnitudeSquared(left) == 0d)
      {
        if (Quaternion<double>.MagnitudeSquared(right) == 0d)
          return Quaternion<double>.FactoryIdentity;
        else
          return new Quaternion<double>(right.X, right.Y, right.Z, right.W);
      }
      else if (Quaternion<double>.MagnitudeSquared(right) == 0d)
        return new Quaternion<double>(left.X, left.Y, left.Z, left.W);
      Quaternion<double> result = new Quaternion<double>(
        1d - blend * left.X + blend * right.X,
        1d - blend * left.Y + blend * right.Y,
        1d - blend * left.Z + blend * right.Z,
        1d - blend * left.W + blend * right.W);
      if (Quaternion<double>.MagnitudeSquared(result) > 0d)
        return Quaternion<double>.Normalize(result);
      else
        return Quaternion<double>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<double> Slerp(Quaternion<double> left, Quaternion<double> right, double blend)
    {
      if (blend < 0d || blend > 1d)
        throw new Error("invalid blending value during slerp !(blend < 0.0f || blend > 1.0f).");
      if (LinearAlgebra.MagnitudeSquared(left) == 0d)
      {
        if (LinearAlgebra.MagnitudeSquared(right) == 0d)
          return Quaternion<double>.FactoryIdentity;
        else
          return new Quaternion<double>(right.X, right.Y, right.Z, right.W);
      }
      else if (LinearAlgebra.MagnitudeSquared(right) == 0d)
        return new Quaternion<double>(left.X, left.Y, left.Z, left.W);
      double cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0d)
        return new Quaternion<double>(left.X, left.Y, left.Z, left.W);
      else if (cosHalfAngle < 0.0f)
      {
        right = new Quaternion<double>(-left.X, -left.Y, -left.Z, -left.W);
        cosHalfAngle = -cosHalfAngle;
      }
      double halfAngle = Trigonometry.arccos(cosHalfAngle);
      double sinHalfAngle = Trigonometry.sin(halfAngle);
      double blendA = Trigonometry.sin(halfAngle * (1f - blend)) / sinHalfAngle;
      double blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      Quaternion<double> result = new Quaternion<double>(
        blendA * left.X + blendB * right.X,
        blendA * left.Y + blendB * right.Y,
        blendA * left.Z + blendB * right.Z,
        blendA * left.W + blendB * right.W);
      if (LinearAlgebra.MagnitudeSquared(result) > 0f)
        return LinearAlgebra.Normalize(result);
      else
        return Quaternion<double>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<double> Rotate(Quaternion<double> rotation, Vector<double> vector)
    {
      if (vector.Dimensions != 3 && vector.Dimensions != 4)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<double> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<double>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<double> left, Quaternion<double> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<double> left, Quaternion<double> right, double leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #region tableau

    const double epsilon = 1.0e-8;
    //int equal(double a, double b) { return fabs(a - b) < epsilon; }

    static void pivot_on(ref double[,] tableau, int row, int col) {
      int i, j;
      double pivot;

      pivot = tableau[row, col];
      if (!(pivot > 0))
        throw new Error("possible invalid tableau values (IDK)");
      for (j = 0; j< tableau.GetLength(1); j++)
        tableau[row, j] /= pivot;
      if (!(Logic.Equate(tableau[row, col], 1.0d, epsilon)))
        throw new Error("possible invalid tableau values (IDK)");

      for (i = 0; i < tableau.GetLength(0); i++)
      { // foreach remaining row i do
        double multiplier = tableau[i, col];
        if (i == row) continue;
        for (j = 0; j < tableau.GetLength(1); j++) { // r[i] = r[i] - z * r[row];
          tableau[i, j] -= multiplier * tableau[row, j];
        }
      }
    }

    // Find pivot_col = most negative column in mat[0][1..n]
    static int find_pivot_column(ref double[,] tableau)
    {
      int j, pivot_col = 1;
      double lowest = tableau[0, pivot_col];
      for (j = 1; j < tableau.GetLength(1); j++)
      {
        if (tableau[0, j] < lowest)
        {
          lowest = tableau[0, j];
          pivot_col = j;
        }
      }
      //printf("Most negative column in row[0] is col %d = %g.\n", pivot_col, lowest);
      if (lowest >= 0)
      {
        return -1; // All positive columns in row[0], this is optimal.
      }
      return pivot_col;
    }

    // Find the pivot_row, with smallest positive ratio = col[0] / col[pivot]
    static int find_pivot_row(ref double[,] tableau, int pivot_col)
    {
      int i, pivot_row = 0;
      double min_ratio = -1;
      //printf("Ratios A[row_i,0]/A[row_i,%d] = [", pivot_col);
      for (i = 1; i < tableau.GetLength(0); i++)
      {
        double ratio = tableau[i, 0] / tableau[i, pivot_col];
        //printf("%3.2lf, ", ratio);
        if ((ratio > 0 && ratio < min_ratio) || min_ratio < 0)
        {
          min_ratio = ratio;
          pivot_row = i;
        }
      }
      //printf("].\n");
      if (min_ratio == -1)
        return -1; // Unbounded.
      //printf("Found pivot A[%d,%d], min positive ratio=%g in row=%d.\n",
      //  pivot_row, pivot_col, min_ratio, pivot_row);
      return pivot_row;
    }

    static void add_slack_variables(ref double[,] tableau)
    {

      double[,] newTableau =
        new double[tableau.GetLength(0), tableau.GetLength(1) + tableau.GetLength(0) - 1];

      for (int a = 0, a_max = tableau.GetLength(0); a < a_max; a++)
        for (int b = 0, b_max = tableau.GetLength(1); b < b_max; b++)
          newTableau[a, b] = tableau[a, b];

      int i, j;
      for (i = 1; i < tableau.GetLength(0); i++)
      {
        for (j = 1; j < tableau.GetLength(0); j++)
          newTableau[i, j + tableau.GetLength(1) - 1] = (i == j ? 1d : 0d);
      }

      tableau = newTableau;
    }

    static void check_b_positive(ref double[,] tableau)
    {
      int i;
      for (i = 1; i < tableau.GetLength(0); i++)
        if (!(tableau[i, 0] >= 0))
          throw new Error("possible invalid tableau values (IDK)");
    }

    // Given a column of identity matrix, find the row containing 1.
    // return -1, if the column as not from an identity matrix.
    static int find_basis_variable(ref double[,] tableau, int col)
    {
      int i, xi = -1;
      for (i = 1; i < tableau.GetLength(0); i++)
      {
        if (Logic.Equate(tableau[i, col], 1, epsilon))
          if (xi == -1)
            xi = i;   // found first '1', save this row number.
          else
            return -1; // found second '1', not an identity matrix.
        else if (!Logic.Equate(tableau[i, col], 0, epsilon))
          return -1; // not an identity matrix column.
      }
      return xi;
    }

    static double[] print_optimal_vector(ref double[,] tableau)
    {
      double[] vector = new double[tableau.GetLength(1)];
      int j, xi;
      //printf("%s at ", message);
      for (j = 1; j < tableau.GetLength(1); j++)
      { // for each column.
        xi = find_basis_variable(ref tableau, j);
        if (xi != -1)
          vector[j] = tableau[xi, 0];
        else
          vector[j] = j;
      }
      return vector;
    }

    public static double[] Simplex(ref double[,] tableau)
    {
      int loop = 0;
      add_slack_variables(ref tableau);
      check_b_positive(ref tableau);
      while (++loop > 0)
      {
        int pivot_col, pivot_row;

        pivot_col = find_pivot_column(ref tableau);
        if (pivot_col < 0)
          //printf("Found optimal value=A[0,0]=%3.2lf (no negatives in row 0).\n",
          //  tableau->mat[0][0]);
          return print_optimal_vector(ref tableau);
        //printf("Entering variable x%d to be made basic, so pivot_col=%d.\n",
        //  pivot_col, pivot_col);

        pivot_row = find_pivot_row(ref tableau, pivot_col);
        if (pivot_row < 0)
          throw new Error("unbounded (no pivot_row)");
        //printf("Leaving variable x%d, so pivot_row=%d\n", pivot_row, pivot_row);

        pivot_on(ref tableau, pivot_row, pivot_col);
        //print_tableau(tableau, "After pivoting");
        //return print_optimal_vector(ref tableau);
      }
      throw new Error("Simplex has a glitch");
    }

    #endregion

    #endregion

    #region float

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static float[] Add(float[] left, float[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      float[] result = new float[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static float[] Negate(float[] vector)
    {
      float[] result = new float[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static float[] Subtract(float[] left, float[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      float[] result = new float[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static float[] Multiply(float[] left, float right)
    {
      float[] result = new float[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static float[] Divide(float[] vector, float right)
    {
      float[] result = new float[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static float DotProduct(float[] left, float[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      float result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static float[] CrossProduct(float[] left, float[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new float[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static float[] Normalize(float[] vector)
    {
      float length = LinearAlgebra.Magnitude(vector);
      if (length != 0.0)
      {
        float[] result = new float[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new float[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static float Magnitude(float[] vector)
    {
      float result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (float)System.Math.Sqrt(result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static float MagnitudeSquared(float[] vector)
    {
      float result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static float Angle(float[] first, float[] second)
    {
      return (float)System.Math.Acos(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second)));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static float[] RotateBy(float[] vector, float angle, float x, float y, float z)
    {
      if (vector.Length == 3)
      {
        // Note: the angle is in radians
        float sinHalfAngle = (float)System.Math.Sin(angle / 2);
        float cosHalfAngle = (float)System.Math.Cos(angle / 2);
        x *= sinHalfAngle;
        y *= sinHalfAngle;
        z *= sinHalfAngle;
        float x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
        float y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
        float z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
        float w2 = -x * vector[0] - y * vector[1] - z * vector[2];
        return new float[] {
          x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
          y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
          z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      }
      throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static float[] RotateBy(float[] vector, Quaternion<float> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static float[] Lerp(float[] left, float[] right, float blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      float[] result = new float[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static float[] Slerp(float[] left, float[] right, float blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      float dot = LinearAlgebra.DotProduct(left, right);
      dot = dot < -1.0f ? -1.0f : dot;
      dot = dot > 1.0f ? 1.0f : dot;
      float theta = (float)System.Math.Acos(dot) * blend;
      return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, (float)System.Math.Cos(theta)),
        LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), (float)System.Math.Sin(theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static float[] Blerp(float[] a, float[] b, float[] c, float u, float v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(float[] left, float[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(float[] left, float[] right, float leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(float[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static float[,] MatrixFactoryIdentity_float(int rows, int columns)
    {
      float[,] matrix;
      try { matrix = new float[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static float[,] Negate(float[,] matrix)
    {
      float[,] result = new float[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static float[,] Add(float[,] left, float[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      float[,] result = new float[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static float[,] Subtract(float[,] left, float[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      float[,] result = new float[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static float[,] Multiply(float[,] left, float[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      float[,] result = new float[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static float[] Multiply(float[,] left, float[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      float[] result = new float[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j] * right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static float[,] Multiply(float[,] left, float right)
    {
      float[,] result = new float[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static float[,] Power(float[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_float(matrix.GetLength(0), matrix.GetLength(1));
      float[,] result = matrix.Clone() as float[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static float[,] Divide(float[,] matrix, float right)
    {
      float[,] result = new float[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static float[,] Minor(float[,] matrix, int row, int column)
    {
      float[,] minor = new float[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static float[,] ConcatenateRowWise(float[,] left, float[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      float[,] result = new float[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static float[,] Echelon(float[,] matrix)
    {
      try
      {
        float[,] result = matrix.Clone() as float[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static float[,] ReducedEchelon(float[,] matrix)
    {
      try
      {
        float[,] result = matrix.Clone() as float[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static float Determinent(float[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        float det = 1.0f;
        float[,] rref = matrix.Clone() as float[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static float[,] Inverse(float[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        float[,] identity = LinearAlgebra.MatrixFactoryIdentity_float(matrix.GetLength(0), matrix.GetLength(1));
        float[,] rref = matrix.Clone() as float[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static float[,] Adjoint(float[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      float[,] AdjointMatrix = new float[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static float[,] Transpose(float[,] matrix)
    {
      float[,] transpose = new float[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(float[,] matrix, out float[,] Lower, out float[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_float(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as float[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      float p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static float[,] Clone(float[,] matrix)
    {
      float[,] result = new float[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(float[,] matrix, int row, float scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(float[,] matrix, int target, int second, float scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(float[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        float temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(float[,] left, float[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(float[,] left, float[,] right, float leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static float Magnitude(Quaternion<float> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static float MagnitudeSquared(Quaternion<float> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<float> Conjugate(Quaternion<float> quaternion)
    {
      return new Quaternion<float>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<float> Add(Quaternion<float> left, Quaternion<float> right)
    {
      return new Quaternion<float>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<float> Subtract(Quaternion<float> left, Quaternion<float> right)
    {
      return new Quaternion<float>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<float> Multiply(Quaternion<float> left, Quaternion<float> right)
    {
      return new Quaternion<float>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<float> Multiply(Quaternion<float> left, float right)
    {
      return new Quaternion<float>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<float> Multiply(Quaternion<float> left, Vector<float> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<float>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<float> Normalize(Quaternion<float> quaternion)
    {
      float normalizer = Quaternion<float>.Magnitude(quaternion);
      if (normalizer != 0f)
        return quaternion * (1f / normalizer);
      else
        return Quaternion<float>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<float> Invert(Quaternion<float> quaternion)
    {
      float normalizer = Quaternion<float>.MagnitudeSquared(quaternion);
      if (normalizer == 0f)
        return new Quaternion<float>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1f / normalizer;
      return new Quaternion<float>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<float> Lerp(Quaternion<float> left, Quaternion<float> right, float blend)
    {
      if (blend < 0f || blend > 1f)
        throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      if (Quaternion<float>.MagnitudeSquared(left) == 0f)
      {
        if (Quaternion<float>.MagnitudeSquared(right) == 0f)
          return Quaternion<float>.FactoryIdentity;
        else
          return new Quaternion<float>(right.X, right.Y, right.Z, right.W);
      }
      else if (Quaternion<float>.MagnitudeSquared(right) == 0f)
        return new Quaternion<float>(left.X, left.Y, left.Z, left.W);
      Quaternion<float> result = new Quaternion<float>(
        1f - blend * left.X + blend * right.X,
        1f - blend * left.Y + blend * right.Y,
        1f - blend * left.Z + blend * right.Z,
        1f - blend * left.W + blend * right.W);
      if (Quaternion<float>.MagnitudeSquared(result) > 0f)
        return Quaternion<float>.Normalize(result);
      else
        return Quaternion<float>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<float> Slerp(Quaternion<float> left, Quaternion<float> right, float blend)
    {
      if (blend < 0f || blend > 1f)
        throw new Error("invalid blending value during slerp !(blend < 0.0f || blend > 1.0f).");
      if (LinearAlgebra.MagnitudeSquared(left) == 0f)
      {
        if (LinearAlgebra.MagnitudeSquared(right) == 0f)
          return Quaternion<float>.FactoryIdentity;
        else
          return new Quaternion<float>(right.X, right.Y, right.Z, right.W);
      }
      else if (LinearAlgebra.MagnitudeSquared(right) == 0f)
        return new Quaternion<float>(left.X, left.Y, left.Z, left.W);
      float cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
        return new Quaternion<float>(left.X, left.Y, left.Z, left.W);
      else if (cosHalfAngle < 0.0f)
      {
        right = new Quaternion<float>(-left.X, -left.Y, -left.Z, -left.W);
        cosHalfAngle = -cosHalfAngle;
      }
      float halfAngle = Trigonometry.arccos(cosHalfAngle);
      float sinHalfAngle = Trigonometry.sin(halfAngle);
      float blendA = Trigonometry.sin(halfAngle * (1f - blend)) / sinHalfAngle;
      float blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      Quaternion<float> result = new Quaternion<float>(
        blendA * left.X + blendB * right.X,
        blendA * left.Y + blendB * right.Y,
        blendA * left.Z + blendB * right.Z,
        blendA * left.W + blendB * right.W);
      if (LinearAlgebra.MagnitudeSquared(result) > 0f)
        return LinearAlgebra.Normalize(result);
      else
        return Quaternion<float>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<float> Rotate(Quaternion<float> rotation, Vector<float> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<float> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<float>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<float> left, Quaternion<float> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<float> left, Quaternion<float> right, float leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #region long

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static long[] Add(long[] left, long[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      long[] result = new long[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static long[] Negate(long[] vector)
    {
      long[] result = new long[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static long[] Subtract(long[] left, long[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      long[] result = new long[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static long[] Multiply(long[] left, long right)
    {
      long[] result = new long[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static long[] Divide(long[] vector, long right)
    {
      long[] result = new long[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static long DotProduct(long[] left, long[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      long result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static long[] CrossProduct(long[] left, long[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new long[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static long[] Normalize(long[] vector)
    {
      long length = LinearAlgebra.Magnitude(vector);
      if (length != 0.0)
      {
        long[] result = new long[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new long[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static long Magnitude(long[] vector)
    {
      long result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (long)System.Math.Sqrt(result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static long MagnitudeSquared(long[] vector)
    {
      long result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static long Angle(long[] first, long[] second)
    {
      throw new Error("Angle is a rational operation that cannot be performed on long[,]");
      //return System.Math.Acos(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second)));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static long[] RotateBy(long[] vector, long angle, long x, long y, long z)
    {
      throw new Error("RotateBy is a rational operation that cannot be performed on long[,]");
      //if (vector.Length == 3)
      //{
      //  // Note: the angle is in radians
      //  long sinHalfAngle = System.Math.Sin(angle / 2);
      //  long cosHalfAngle = System.Math.Cos(angle / 2);
      //  x *= sinHalfAngle;
      //  y *= sinHalfAngle;
      //  z *= sinHalfAngle;
      //  long x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
      //  long y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
      //  long z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
      //  long w2 = -x * vector[0] - y * vector[1] - z * vector[2];
      //  return new long[] {
      //    x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
      //    y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
      //    z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      //}
      //throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static long[] RotateBy(long[] vector, Quaternion<long> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static long[] Lerp(long[] left, long[] right, long blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      long[] result = new long[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static long[] Slerp(long[] left, long[] right, long blend)
    {
      throw new Error("Slerp is a rational operation that cannot be performed on long[,]");
      //if (blend < 0 || blend > 1.0f)
      //  throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      //long dot = LinearAlgebra.DotProduct(left, right);
      //dot = dot < -1.0d ? -1.0d : dot;
      //dot = dot > 1.0d ? 1.0 : dot;
      //long theta = System.Math.Acos(dot) * blend;
      //return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, System.Math.Cos(theta)),
      //  LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), System.Math.Sin(theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static long[] Blerp(long[] a, long[] b, long[] c, long u, long v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(long[] left, long[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(long[] left, long[] right, long leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(long[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static long[,] MatrixFactoryIdentity_long(int rows, int columns)
    {
      long[,] matrix;
      try { matrix = new long[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static long[,] Negate(long[,] matrix)
    {
      long[,] result = new long[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static long[,] Add(long[,] left, long[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      long[,] result = new long[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static long[,] Subtract(long[,] left, long[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      long[,] result = new long[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static long[,] Multiply(long[,] left, long[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      long[,] result = new long[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static long[] Multiply(long[,] left, long[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      long[] result = new long[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j] * right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static long[,] Multiply(long[,] left, long right)
    {
      long[,] result = new long[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static long[,] Power(long[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_long(matrix.GetLength(0), matrix.GetLength(1));
      long[,] result = matrix.Clone() as long[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static long[,] Divide(long[,] matrix, long right)
    {
      long[,] result = new long[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static long[,] Minor(long[,] matrix, int row, int column)
    {
      long[,] minor = new long[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static long[,] ConcatenateRowWise(long[,] left, long[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      long[,] result = new long[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static long[,] Echelon(long[,] matrix)
    {
      try
      {
        long[,] result = matrix.Clone() as long[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static long[,] ReducedEchelon(long[,] matrix)
    {
      try
      {
        long[,] result = matrix.Clone() as long[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static long Determinent(long[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        long det = 1;
        long[,] rref = matrix.Clone() as long[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static long[,] Inverse(long[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        long[,] identity = LinearAlgebra.MatrixFactoryIdentity_long(matrix.GetLength(0), matrix.GetLength(1));
        long[,] rref = matrix.Clone() as long[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static long[,] Adjoint(long[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      long[,] AdjointMatrix = new long[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static long[,] Transpose(long[,] matrix)
    {
      long[,] transpose = new long[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(long[,] matrix, out long[,] Lower, out long[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_long(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as long[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      long p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static long[,] Clone(long[,] matrix)
    {
      long[,] result = new long[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(long[,] matrix, int row, long scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(long[,] matrix, int target, int second, long scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(long[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        long temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(long[,] left, long[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(long[,] left, long[,] right, long leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static long Magnitude(Quaternion<long> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static long MagnitudeSquared(Quaternion<long> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<long> Conjugate(Quaternion<long> quaternion)
    {
      return new Quaternion<long>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<long> Add(Quaternion<long> left, Quaternion<long> right)
    {
      return new Quaternion<long>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<long> Subtract(Quaternion<long> left, Quaternion<long> right)
    {
      return new Quaternion<long>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<long> Multiply(Quaternion<long> left, Quaternion<long> right)
    {
      return new Quaternion<long>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<long> Multiply(Quaternion<long> left, long right)
    {
      return new Quaternion<long>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<long> Multiply(Quaternion<long> left, Vector<long> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<long>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<long> Normalize(Quaternion<long> quaternion)
    {
      long normalizer = Quaternion<long>.Magnitude(quaternion);
      if (normalizer != 0)
        return quaternion * (1 / normalizer);
      else
        return Quaternion<long>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<long> Invert(Quaternion<long> quaternion)
    {
      long normalizer = Quaternion<long>.MagnitudeSquared(quaternion);
      if (normalizer == 0d)
        return new Quaternion<long>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1 / normalizer;
      return new Quaternion<long>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<long> Lerp(Quaternion<long> left, Quaternion<long> right, long blend)
    {
      throw new Error("Quaternion Lerp requires a rational (long is not)");
      //if (blend < 0d || blend > 1d)
      //  throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      //if (Quaternion<long>.MagnitudeSquared(left) == 0d)
      //{
      //  if (Quaternion<long>.MagnitudeSquared(right) == 0d)
      //    return Quaternion<long>.FactoryIdentity;
      //  else
      //    return new Quaternion<long>(right.X, right.Y, right.Z, right.W);
      //}
      //else if (Quaternion<long>.MagnitudeSquared(right) == 0d)
      //  return new Quaternion<long>(left.X, left.Y, left.Z, left.W);
      //Quaternion<long> result = new Quaternion<long>(
      //  1d - blend * left.X + blend * right.X,
      //  1d - blend * left.Y + blend * right.Y,
      //  1d - blend * left.Z + blend * right.Z,
      //  1d - blend * left.W + blend * right.W);
      //if (Quaternion<long>.MagnitudeSquared(result) > 0d)
      //  return Quaternion<long>.Normalize(result);
      //else
      //  return Quaternion<long>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<long> Slerp(Quaternion<long> left, Quaternion<long> right, long blend)
    {
      throw new Error("Quaternion Slerp requires a rational (long is not)");
      //if (blend < 0d || blend > 1d)
      //  throw new Error("invalid blending value during slerp !(blend < 0.0f || blend > 1.0f).");
      //if (LinearAlgebra.MagnitudeSquared(left) == 0d)
      //{
      //  if (LinearAlgebra.MagnitudeSquared(right) == 0d)
      //    return Quaternion<long>.FactoryIdentity;
      //  else
      //    return new Quaternion<long>(right.X, right.Y, right.Z, right.W);
      //}
      //else if (LinearAlgebra.MagnitudeSquared(right) == 0d)
      //  return new Quaternion<long>(left.X, left.Y, left.Z, left.W);
      //long cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      //if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0d)
      //  return new Quaternion<long>(left.X, left.Y, left.Z, left.W);
      //else if (cosHalfAngle < 0.0f)
      //{
      //  right = new Quaternion<long>(-left.X, -left.Y, -left.Z, -left.W);
      //  cosHalfAngle = -cosHalfAngle;
      //}
      //long halfAngle = Trigonometry.arccos(cosHalfAngle);
      //long sinHalfAngle = Trigonometry.sin(halfAngle);
      //long blendA = Trigonometry.sin(halfAngle * (1f - blend)) / sinHalfAngle;
      //long blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      //Quaternion<long> result = new Quaternion<long>(
      //  blendA * left.X + blendB * right.X,
      //  blendA * left.Y + blendB * right.Y,
      //  blendA * left.Z + blendB * right.Z,
      //  blendA * left.W + blendB * right.W);
      //if (LinearAlgebra.MagnitudeSquared(result) > 0f)
      //  return LinearAlgebra.Normalize(result);
      //else
      //  return Quaternion<long>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<long> Rotate(Quaternion<long> rotation, Vector<long> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<long> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<long>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<long> left, Quaternion<long> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<long> left, Quaternion<long> right, long leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #region int

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static int[] Add(int[] left, int[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector addition.");
      int[] result = new int[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + right[i];
      return result;
    }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static int[] Negate(int[] vector)
    {
      int[] result = new int[vector.Length];
      for (int i = 0; i < vector.Length; i++)
        result[i] = -vector[i];
      return result;
    }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static int[] Subtract(int[] left, int[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector subtraction.");
      int[] result = new int[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] - right[i];
      return result;
    }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static int[] Multiply(int[] left, int right)
    {
      int[] result = new int[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] * right;
      return result;
    }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static int[] Divide(int[] vector, int right)
    {
      int[] result = new int[vector.Length];
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result[i] = vector[i] / right;
      return result;
    }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static int DotProduct(int[] left, int[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid dimensions on vector dot product.");
      int result = 0;
      for (int i = 0; i < left.Length; i++)
        result += (left[i] * right[i]);
      return result;
    }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static int[] CrossProduct(int[] left, int[] right)
    {
      if (left.Length != right.Length)
        throw new Error("invalid cross product !(left.Dimensions == right.Dimensions)");
      if (left.Length == 3 || left.Length == 4)
      {
        return new int[] {
          left[1] * right[2] - left[2] * right[1],
          left[2] * right[0] - left[0] * right[2],
          left[0] * right[1] - left[1] * right[0] };
      }
      throw new Error("my cross product function is only defined for 3-component vectors.");
    }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static int[] Normalize(int[] vector)
    {
      int length = LinearAlgebra.Magnitude(vector);
      if (length != 0.0)
      {
        int[] result = new int[vector.Length];
        for (int i = 0; i < vector.Length; i++)
          result[i] = vector[i] / length;
        return result;
      }
      else
        return new int[vector.Length];
    }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static int Magnitude(int[] vector)
    {
      int result = 0;
      int arrayLength = vector.Length;
      for (int i = 0; i < arrayLength; i++)
        result += (vector[i] * vector[i]);
      return (int)System.Math.Sqrt(result);
    }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static int MagnitudeSquared(int[] vector)
    {
      int result = 0;
      for (int i = 0; i < vector.Length; i++)
        result += (vector[i] * vector[i]);
      return result;
    }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static int Angle(int[] first, int[] second)
    {
      throw new Error("Angle is a rational operation that cannot be performed on int[,]");
      //return System.Math.Acos(LinearAlgebra.DotProduct(first, second) / (LinearAlgebra.Magnitude(first) * LinearAlgebra.Magnitude(second)));
    }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static int[] RotateBy(int[] vector, int angle, int x, int y, int z)
    {
      throw new Error("Angle is a rational operation that cannot be performed on int[,]");
      //if (vector.Length == 3)
      //{
      //  // Note: the angle is in radians
      //  int sinHalfAngle = System.Math.Sin(angle / 2);
      //  int cosHalfAngle = System.Math.Cos(angle / 2);
      //  x *= sinHalfAngle;
      //  y *= sinHalfAngle;
      //  z *= sinHalfAngle;
      //  int x2 = cosHalfAngle * vector[0] + y * vector[2] - z * vector[1];
      //  int y2 = cosHalfAngle * vector[1] + z * vector[0] - x * vector[2];
      //  int z2 = cosHalfAngle * vector[2] + x * vector[1] - y * vector[0];
      //  int w2 = -x * vector[0] - y * vector[1] - z * vector[2];
      //  return new int[] {
      //    x * w2 + cosHalfAngle * x2 + y * z2 - z * y2,
      //    y * w2 + cosHalfAngle * y2 + z * x2 - x * z2,
      //    z * w2 + cosHalfAngle * z2 + x * y2 - y * x2 };
      //}
      //throw new Error("my RotateBy() function is only defined for 3-component vectors.");
    }

    /// <summary>Rotates a vector by a quaternion rotation.</summary>
    /// <param name="vector">The vector to be rotated.</param>
    /// <param name="quaternion">The rotation to be applied.</param>
    /// <returns>The vector after the rotation.</returns>
    public static int[] RotateBy(int[] vector, Quaternion<int> quaternion)
    {
      return Rotate(quaternion, vector);
    }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static int[] Lerp(int[] left, int[] right, int blend)
    {
      if (blend < 0 || blend > 1.0f)
        throw new Error("invalid lerp blend value: (blend < 0.0f || blend > 1.0f).");
      if (left.Length != right.Length)
        throw new Error("invalid lerp matrix length: (left.Dimensions != right.Dimensions)");
      int[] result = new int[left.Length];
      for (int i = 0; i < left.Length; i++)
        result[i] = left[i] + blend * (right[i] - left[i]);
      return result;
    }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static int[] Slerp(int[] left, int[] right, int blend)
    {
      throw new Error("Slerp is a rational operation that cannot be performed on int[,]");
      //if (blend < 0 || blend > 1.0f)
      //  throw new Error("invalid slerp blend value: (blend < 0.0f || blend > 1.0f).");
      //int dot = LinearAlgebra.DotProduct(left, right);
      //dot = dot < -1.0d ? -1.0d : dot;
      //dot = dot > 1.0d ? 1.0 : dot;
      //int theta = System.Math.Acos(dot) * blend;
      //return LinearAlgebra.Multiply(LinearAlgebra.Add(LinearAlgebra.Multiply(left, System.Math.Cos(theta)),
      //  LinearAlgebra.Normalize(LinearAlgebra.Subtract(right, LinearAlgebra.Multiply(left, dot)))), System.Math.Sin(theta));
    }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static int[] Blerp(int[] a, int[] b, int[] c, int u, int v)
    {
      return LinearAlgebra.Add(LinearAlgebra.Add(LinearAlgebra.Multiply(LinearAlgebra.Subtract(b, a), u),
        LinearAlgebra.Multiply(LinearAlgebra.Subtract(c, a), v)), a);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(int[] left, int[] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (left[i] != right[i])
          return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(int[] left, int[] right, int leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        if (Logic.Abs(left[i] - right[i]) > leniency)
          return false;
      return true;
    }

    #endregion

    #region matrix

    /// <summary>Determines if a matrix is symetric or not.</summary>
    /// <param name="matrix">The matrix to determine symetry of.</param>
    /// <returns>True if symetric; false if not.</returns>
    public static bool IsSymmetric(int[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      if (rows != cols)
        return false;

      for (var row = 0; row < rows; row++)
        for (var column = row + 1; column < cols; column++)
          if (matrix[row, column] != matrix[column, row])
            return false;

      return true;
    }

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static int[,] MatrixFactoryIdentity_int(int rows, int columns)
    {
      int[,] matrix;
      try { matrix = new int[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = 1;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = 1;
      return matrix;
    }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static int[,] Negate(int[,] matrix)
    {
      int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = -matrix[i, j];
      return result;
    }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static int[,] Add(int[,] left, int[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid addition (size miss-match).");
      int[,] result = new int[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] + right[i, j];
      return result;
    }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static int[,] Subtract(int[,] left, int[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        throw new Error("invalid subtraction (size miss-match).");
      int[,] result = new int[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          result[i, j] = left[i, j] - right[i, j];
      return result;
    }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static int[,] Multiply(int[,] left, int[,] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new LinearAlgebra.Error("invalid multiplication (size miss-match).");
      int[,] result = new int[left.GetLength(0), right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
          for (int k = 0; k < left.GetLength(1); k++)
            result[i, j] += left[i, k] * right[k, j];
      return result;
    }

    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static int[] Multiply(int[,] left, int[] right)
    {
      if (left.GetLength(1) != right.GetLength(0))
        throw new Error("invalid multiplication (size miss-match).");
      int[] result = new int[left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < right.GetLength(1); j++)
          result[i] = result[i] + left[i, j] * right[j];
      return result;
    }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static int[,] Multiply(int[,] left, int right)
    {
      int[,] result = new int[left.GetLength(0), left.GetLength(1)];
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          result[i, j] = left[i, j] * right;
      return result;
    }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static int[,] Power(int[,] matrix, int power)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid power (!matrix.IsSquare).");
      if (!(power >= 0))
        throw new Error("invalid power !(power > -1)");
      if (power == 0)
        return LinearAlgebra.MatrixFactoryIdentity_int(matrix.GetLength(0), matrix.GetLength(1));
      int[,] result = matrix.Clone() as int[,];
      for (int i = 0; i < power; i++)
        result = LinearAlgebra.Multiply(result, result);
      return result;
    }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static int[,] Divide(int[,] matrix, int right)
    {
      int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j] / right;
      return result;
    }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static int[,] Minor(int[,] matrix, int row, int column)
    {
      int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, n = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == column) continue;
          minor[m, n] = matrix[i, j];
          n++;
        }
        m++;
      }
      return minor;
    }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static int[,] ConcatenateRowWise(int[,] left, int[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0))
        throw new Error("invalid row-wise concatenation !(left.Rows == right.Rows).");
      int[,] result = new int[left.GetLength(0), left.GetLength(1) + right.GetLength(1)];
      for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
          if (j < left.GetLength(1)) result[i, j] = left[i, j];
          else result[i, j] = right[i, j - left.GetLength(1)];
        }
      return result;
    }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static int[,] Echelon(int[,] matrix)
    {
      try
      {
        int[,] result = matrix.Clone() as int[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0)
            continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("echelon computation failed."); }
    }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static int[,] ReducedEchelon(int[,] matrix)
    {
      try
      {
        int[,] result = matrix.Clone() as int[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (result[i, i] == 0)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] != 0)
                LinearAlgebra.SwapRows(result, i, j);
          if (result[i, i] == 0) continue;
          if (result[i, i] != 1)
            for (int j = i + 1; j < result.GetLength(0); j++)
              if (result[j, i] == 1)
                LinearAlgebra.SwapRows(result, i, j);
          LinearAlgebra.RowMultiplication(result, i, 1 / result[i, i]);
          for (int j = i + 1; j < result.GetLength(0); j++)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(result, j, i, -result[j, i]);
        }
        return result;
      }
      catch { throw new Error("reduced echelon calculation failed."); }
    }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static int Determinent(int[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("invalid determinent !(matrix.IsSquare).");
      try
      {
        int det = 1;
        int[,] rref = matrix.Clone() as int[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                det *= -1;
              }
          det *= rref[i, i];
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          for (int j = i - 1; j >= 0; j--)
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
        }
        return det;
      }
      catch { throw new Error("determinent computation failed."); }
    }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static int[,] Inverse(int[,] matrix)
    {
      if (LinearAlgebra.Determinent(matrix) == 0)
        throw new Error("inverse calculation failed.");
      try
      {
        int[,] identity = LinearAlgebra.MatrixFactoryIdentity_int(matrix.GetLength(0), matrix.GetLength(1));
        int[,] rref = matrix.Clone() as int[,];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          if (rref[i, i] == 0)
            for (int j = i + 1; j < rref.GetLength(0); j++)
              if (rref[j, i] != 0)
              {
                LinearAlgebra.SwapRows(rref, i, j);
                LinearAlgebra.SwapRows(identity, i, j);
              }
          LinearAlgebra.RowMultiplication(identity, i, 1 / rref[i, i]);
          LinearAlgebra.RowMultiplication(rref, i, 1 / rref[i, i]);
          for (int j = i + 1; j < rref.GetLength(0); j++)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
          for (int j = i - 1; j >= 0; j--)
          {
            LinearAlgebra.RowAddition(identity, j, i, -rref[j, i]);
            LinearAlgebra.RowAddition(rref, j, i, -rref[j, i]);
          }
        }
        return identity;
      }
      catch { throw new Error("inverse calculation failed."); }
    }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static int[,] Adjoint(int[,] matrix)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("Adjoint of a non-square matrix does not exists");
      int[,] AdjointMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          if ((i + j) % 2 == 0)
            AdjointMatrix[i, j] = LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
          else
            AdjointMatrix[i, j] = -LinearAlgebra.Determinent(LinearAlgebra.Minor(matrix, i, j));
      return LinearAlgebra.Transpose(AdjointMatrix);
    }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static int[,] Transpose(int[,] matrix)
    {
      int[,] transpose = new int[matrix.GetLength(1), matrix.GetLength(0)];
      for (int i = 0; i < transpose.GetLength(0); i++)
        for (int j = 0; j < transpose.GetLength(1); j++)
          transpose[i, j] = matrix[j, i];
      return transpose;
    }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="Lower">The computed lower triangular matrix.</param>
    /// <param name="Upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(int[,] matrix, out int[,] Lower, out int[,] Upper)
    {
      if (!(matrix.GetLength(0) == matrix.GetLength(1)))
        throw new Error("The matrix is not square!");
      Lower = LinearAlgebra.MatrixFactoryIdentity_int(matrix.GetLength(0), matrix.GetLength(1));
      Upper = matrix.Clone() as int[,];
      int[] permutation = new int[matrix.GetLength(0)];
      for (int i = 0; i < matrix.GetLength(0); i++) permutation[i] = i;
      int p = 0, pom2, detOfP = 1;
      int k0 = 0, pom1 = 0;
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        p = 0;
        for (int i = k; i < matrix.GetLength(0); i++)
          if ((Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k]) > p)
          {
            p = Upper[i, k] > 0 ? Upper[i, k] : -Upper[i, k];
            k0 = i;
          }
        if (p == 0)
          throw new Error("The matrix is singular!");
        pom1 = permutation[k];
        permutation[k] = permutation[k0];
        permutation[k0] = pom1;
        for (int i = 0; i < k; i++)
        {
          pom2 = Lower[k, i];
          Lower[k, i] = Lower[k0, i];
          Lower[k0, i] = pom2;
        }
        if (k != k0)
          detOfP *= -1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
          pom2 = Upper[k, i];
          Upper[k, i] = Upper[k0, i];
          Upper[k0, i] = pom2;
        }
        for (int i = k + 1; i < matrix.GetLength(0); i++)
        {
          Lower[i, k] = Upper[i, k] / Upper[k, k];
          for (int j = k; j < matrix.GetLength(1); j++)
            Upper[i, j] = Upper[i, j] - Lower[i, k] * Upper[k, j];
        }
      }
    }

    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static int[,] Clone(int[,] matrix)
    {
      int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          result[i, j] = matrix[i, j];
      return result;
    }

    private static void RowMultiplication(int[,] matrix, int row, int scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[row, j] *= scalar;
    }

    private static void RowAddition(int[,] matrix, int target, int second, int scalar)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[target, j] += (matrix[second, j] * scalar);
    }

    private static void SwapRows(int[,] matrix, int row1, int row2)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        int temp = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = temp;
      }
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(int[,] left, int[,] right)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (left[i, j] != right[i, j])
            return false;
      return true;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(int[,] left, int[,] right, int leniency)
    {
      if (left.GetLength(0) != right.GetLength(0) || left.GetLength(1) != right.GetLength(1))
        return false;
      for (int i = 0; i < left.GetLength(0); i++)
        for (int j = 0; j < left.GetLength(1); j++)
          if (Logic.Abs(left[i, j] - right[i, j]) > leniency)
            return false;
      return true;
    }

    #endregion

    #region quaterion

    /// <summary>Computes the length of quaternion.</summary>
    /// <param name="quaternion">The quaternion to compute the length of.</param>
    /// <returns>The length of the given quaternion.</returns>
    public static int Magnitude(Quaternion<int> quaternion)
    {
      return Algebra.sqrt(
          (quaternion.X * quaternion.X +
          quaternion.Y * quaternion.Y +
          quaternion.Z * quaternion.Z +
          quaternion.W * quaternion.W));
    }

    /// <summary>Computes the length of a quaternion, but doesn't square root it
    /// for optimization possibilities.</summary>
    /// <param name="quaternion">The quaternion to compute the length squared of.</param>
    /// <returns>The squared length of the given quaternion.</returns>
    public static int MagnitudeSquared(Quaternion<int> quaternion)
    {
      return
        quaternion.X * quaternion.X +
        quaternion.Y * quaternion.Y +
        quaternion.Z * quaternion.Z +
        quaternion.W * quaternion.W;
    }

    /// <summary>Gets the conjugate of the quaternion.</summary>
    /// <param name="quaternion">The quaternion to conjugate.</param>
    /// <returns>The conjugate of teh given quaternion.</returns>
    public static Quaternion<int> Conjugate(Quaternion<int> quaternion)
    {
      return new Quaternion<int>(
        -quaternion.X,
        -quaternion.Y,
        -quaternion.Z,
        quaternion.W);
    }

    /// <summary>Adds two quaternions together.</summary>
    /// <param name="left">The first quaternion of the addition.</param>
    /// <param name="right">The second quaternion of the addition.</param>
    /// <returns>The result of the addition.</returns>
    public static Quaternion<int> Add(Quaternion<int> left, Quaternion<int> right)
    {
      return new Quaternion<int>(
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W);
    }

    /// <summary>Subtracts two quaternions.</summary>
    /// <param name="left">The left quaternion of the subtraction.</param>
    /// <param name="right">The right quaternion of the subtraction.</param>
    /// <returns>The resulting quaternion after the subtraction.</returns>
    public static Quaternion<int> Subtract(Quaternion<int> left, Quaternion<int> right)
    {
      return new Quaternion<int>(
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W);
    }

    /// <summary>Multiplies two quaternions together.</summary>
    /// <param name="left">The first quaternion of the multiplication.</param>
    /// <param name="right">The second quaternion of the multiplication.</param>
    /// <returns>The resulting quaternion after the multiplication.</returns>
    public static Quaternion<int> Multiply(Quaternion<int> left, Quaternion<int> right)
    {
      return new Quaternion<int>(
        left.X * right.W + left.W * right.X + left.Y * right.Z - left.Z * right.Y,
        left.Y * right.W + left.W * right.Y + left.Z * right.X - left.X * right.Z,
        left.Z * right.W + left.W * right.Z + left.X * right.Y - left.Y * right.X,
        left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
    /// <param name="left">The quaternion of the multiplication.</param>
    /// <param name="right">The scalar of the multiplication.</param>
    /// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
    public static Quaternion<int> Multiply(Quaternion<int> left, int right)
    {
      return new Quaternion<int>(
        left.X * right,
        left.Y * right,
        left.Z * right,
        left.W * right);
    }

    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<int> Multiply(Quaternion<int> left, Vector<int> right)
    {
      if (right.Dimensions == 3)
      {
        return new Quaternion<int>(
          left.W * right.X + left.Y * right.Z - left.Z * right.Y,
          left.W * right.Y + left.Z * right.X - left.X * right.Z,
          left.W * right.Z + left.X * right.Y - left.Y * right.X,
          -left.X * right.X - left.Y * right.Y - left.Z * right.Z);
      }
      else
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
    }

    /// <summary>Normalizes the quaternion.</summary>
    /// <param name="quaternion">The quaternion to normalize.</param>
    /// <returns>The normalization of the given quaternion.</returns>
    public static Quaternion<int> Normalize(Quaternion<int> quaternion)
    {
      int normalizer = Quaternion<int>.Magnitude(quaternion);
      if (normalizer != 0)
        return quaternion * (1 / normalizer);
      else
        return Quaternion<int>.FactoryIdentity;
    }

    /// <summary>Inverts a quaternion.</summary>
    /// <param name="quaternion">The quaternion to find the inverse of.</param>
    /// <returns>The inverse of the given quaternion.</returns>
    public static Quaternion<int> Invert(Quaternion<int> quaternion)
    {
      int normalizer = Quaternion<int>.MagnitudeSquared(quaternion);
      if (normalizer == 0d)
        return new Quaternion<int>(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
      normalizer = 1 / normalizer;
      return new Quaternion<int>(
        -quaternion.X * normalizer,
        -quaternion.Y * normalizer,
        -quaternion.Z * normalizer,
        quaternion.W * normalizer);
    }

    /// <summary>Lenearly interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<int> Lerp(Quaternion<int> left, Quaternion<int> right, int blend)
    {
      throw new Error("Quaternion Lerp requires a rational (int is not)");
      //if (blend < 0d || blend > 1d)
      //  throw new Error("invalid blending value during lerp !(blend < 0.0f || blend > 1.0f).");
      //if (Quaternion<int>.MagnitudeSquared(left) == 0d)
      //{
      //  if (Quaternion<int>.MagnitudeSquared(right) == 0d)
      //    return Quaternion<int>.FactoryIdentity;
      //  else
      //    return new Quaternion<int>(right.X, right.Y, right.Z, right.W);
      //}
      //else if (Quaternion<int>.MagnitudeSquared(right) == 0d)
      //  return new Quaternion<int>(left.X, left.Y, left.Z, left.W);
      //Quaternion<int> result = new Quaternion<int>(
      //  1d - blend * left.X + blend * right.X,
      //  1d - blend * left.Y + blend * right.Y,
      //  1d - blend * left.Z + blend * right.Z,
      //  1d - blend * left.W + blend * right.W);
      //if (Quaternion<int>.MagnitudeSquared(result) > 0d)
      //  return Quaternion<int>.Normalize(result);
      //else
      //  return Quaternion<int>.FactoryIdentity;
    }

    /// <summary>Sphereically interpolates between two quaternions.</summary>
    /// <param name="left">The starting point of the interpolation.</param>
    /// <param name="right">The ending point of the interpolation.</param>
    /// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Quaternion<int> Slerp(Quaternion<int> left, Quaternion<int> right, int blend)
    {
      throw new Error("Quaternion Slerp requires a rational (int is not)");
      //if (blend < 0d || blend > 1d)
      //  throw new Error("invalid blending value during slerp !(blend < 0.0f || blend > 1.0f).");
      //if (LinearAlgebra.MagnitudeSquared(left) == 0d)
      //{
      //  if (LinearAlgebra.MagnitudeSquared(right) == 0d)
      //    return Quaternion<int>.FactoryIdentity;
      //  else
      //    return new Quaternion<int>(right.X, right.Y, right.Z, right.W);
      //}
      //else if (LinearAlgebra.MagnitudeSquared(right) == 0d)
      //  return new Quaternion<int>(left.X, left.Y, left.Z, left.W);
      //int cosHalfAngle = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
      //if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0d)
      //  return new Quaternion<int>(left.X, left.Y, left.Z, left.W);
      //else if (cosHalfAngle < 0.0f)
      //{
      //  right = new Quaternion<int>(-left.X, -left.Y, -left.Z, -left.W);
      //  cosHalfAngle = -cosHalfAngle;
      //}
      //int halfAngle = Trigonometry.arccos(cosHalfAngle);
      //int sinHalfAngle = Trigonometry.sin(halfAngle);
      //int blendA = Trigonometry.sin(halfAngle * (1f - blend)) / sinHalfAngle;
      //int blendB = Trigonometry.sin(halfAngle * blend) / sinHalfAngle;
      //Quaternion<int> result = new Quaternion<int>(
      //  blendA * left.X + blendB * right.X,
      //  blendA * left.Y + blendB * right.Y,
      //  blendA * left.Z + blendB * right.Z,
      //  blendA * left.W + blendB * right.W);
      //if (LinearAlgebra.MagnitudeSquared(result) > 0f)
      //  return LinearAlgebra.Normalize(result);
      //else
      //  return Quaternion<int>.FactoryIdentity;
    }

    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<int> Rotate(Quaternion<int> rotation, Vector<int> vector)
    {
      if (vector.Dimensions != 3)
        throw new Error("my quaternion rotations are only defined for 3-component vectors.");
      Quaternion<int> answer = LinearAlgebra.Multiply(LinearAlgebra.Multiply(rotation, vector), LinearAlgebra.Conjugate(rotation));
      return new Vector<int>(answer.X, answer.Y, answer.Z);
    }

    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion  to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<int> left, Quaternion<int> right)
    {
      return
        left.X == right.X &&
        left.Y == right.Y &&
        left.Z == right.Z &&
        left.W == right.W;
    }

    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first quaternion to check for equality.</param>
    /// <param name="right">The second quaternion to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Quaternion<int> left, Quaternion<int> right, int leniency)
    {
      return
        Logic.Abs(left.X - right.X) < leniency &&
        Logic.Abs(left.Y - right.Y) < leniency &&
        Logic.Abs(left.Z - right.Z) < leniency &&
        Logic.Abs(left.W - right.W) < leniency;
    }

    #endregion

    #endregion

    #endregion

    #region error

    /// <summary>Error type for all linear algebra computations.</summary>
		internal class Error : Seven.Error
		{
			public Error(string message) : base(message) { }
    }

    #endregion
  }

  /// <summary>Non-generic linear algrbra extension methods for C# arrays.</summary>
  public static class LinearAlgebra_Extensions
  {
    #region Fraction128

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static Fraction128[] Add(this Fraction128[] left, Fraction128[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static Fraction128[] Negate(this Fraction128[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static Fraction128[] Subtract(this Fraction128[] left, Fraction128[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static Fraction128[] Multiply(this Fraction128[] left, Fraction128 right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static Fraction128[] Divide(this Fraction128[] vector, Fraction128 right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static Fraction128 DotProduct(this Fraction128[] left, Fraction128[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static Fraction128[] CrossProduct(this Fraction128[] left, Fraction128[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static Fraction128[] Normalize(this Fraction128[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static Fraction128 Magnitude(this Fraction128[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static Fraction128 MagnitudeSquared(this Fraction128[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static Fraction128 Angle(this Fraction128[] first, Fraction128[] second)
    { return LinearAlgebra.Angle(first, second); }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static Fraction128[] RotateBy(this Fraction128[] vector, Fraction128 angle, Fraction128 x, Fraction128 y, Fraction128 z)
    { return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Fraction128[] Lerp(this Fraction128[] left, Fraction128[] right, Fraction128 blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static Fraction128[] Slerp(this Fraction128[] left, Fraction128[] right, Fraction128 blend)
    { return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static Fraction128[] Blerp(this Fraction128[] a, Fraction128[] b, Fraction128[] c, Fraction128 u, Fraction128 v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Fraction128[,] Negate(this Fraction128[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static Fraction128[,] Add(this Fraction128[,] left, Fraction128[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static Fraction128[,] Subtract(this Fraction128[,] left, Fraction128[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction128[,] Multiply(this Fraction128[,] left, Fraction128[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Fraction128[,] Multiply(this Fraction128[,] left, Fraction128 right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static Fraction128[,] Power(this Fraction128[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static Fraction128[,] Divide(this Fraction128[,] matrix, Fraction128 right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static Fraction128[,] Minor(this Fraction128[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static Fraction128[,] ConcatenateRowWise(this Fraction128[,] left, Fraction128[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static Fraction128[,] Echelon(this Fraction128[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static Fraction128[,] ReducedEchelon(this Fraction128[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static Fraction128 Determinent(this Fraction128[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static Fraction128[,] Inverse(this Fraction128[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static Fraction128[,] Adjoint(this Fraction128[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static Fraction128[,] Transpose(this Fraction128[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this Fraction128[,] matrix, out Fraction128[,] lower, out Fraction128[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion

    #region Fraction64

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static Fraction64[] Add(this Fraction64[] left, Fraction64[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static Fraction64[] Negate(this Fraction64[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static Fraction64[] Subtract(this Fraction64[] left, Fraction64[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static Fraction64[] Multiply(this Fraction64[] left, Fraction64 right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static Fraction64[] Divide(this Fraction64[] vector, Fraction64 right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static Fraction64 DotProduct(this Fraction64[] left, Fraction64[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static Fraction64[] CrossProduct(this Fraction64[] left, Fraction64[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static Fraction64[] Normalize(this Fraction64[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static Fraction64 Magnitude(this Fraction64[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static Fraction64 MagnitudeSquared(this Fraction64[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static Fraction64 Angle(this Fraction64[] first, Fraction64[] second)
    { return LinearAlgebra.Angle(first, second); }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static Fraction64[] RotateBy(this Fraction64[] vector, Fraction64 angle, Fraction64 x, Fraction64 y, Fraction64 z)
    { return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static Fraction64[] Lerp(this Fraction64[] left, Fraction64[] right, Fraction64 blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static Fraction64[] Slerp(this Fraction64[] left, Fraction64[] right, Fraction64 blend)
    { return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static Fraction64[] Blerp(this Fraction64[] a, Fraction64[] b, Fraction64[] c, Fraction64 u, Fraction64 v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Fraction64[,] Negate(this Fraction64[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static Fraction64[,] Add(this Fraction64[,] left, Fraction64[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static Fraction64[,] Subtract(this Fraction64[,] left, Fraction64[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Fraction64[,] Multiply(this Fraction64[,] left, Fraction64[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Fraction64[,] Multiply(this Fraction64[,] left, Fraction64 right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static Fraction64[,] Power(this Fraction64[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static Fraction64[,] Divide(this Fraction64[,] matrix, Fraction64 right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static Fraction64[,] Minor(this Fraction64[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static Fraction64[,] ConcatenateRowWise(this Fraction64[,] left, Fraction64[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static Fraction64[,] Echelon(this Fraction64[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static Fraction64[,] ReducedEchelon(this Fraction64[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static Fraction64 Determinent(this Fraction64[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static Fraction64[,] Inverse(this Fraction64[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static Fraction64[,] Adjoint(this Fraction64[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static Fraction64[,] Transpose(this Fraction64[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this Fraction64[,] matrix, out Fraction64[,] lower, out Fraction64[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion

    #region decimal

    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector of the addition.</param>
    /// <param name="right">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static decimal[] Add(this decimal[] left, decimal[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static decimal[] Negate(this decimal[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static decimal[] Subtract(this decimal[] left, decimal[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static decimal[] Multiply(this decimal[] left, decimal right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static decimal[] Divide(this decimal[] vector, decimal right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static decimal DotProduct(this decimal[] left, decimal[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static decimal[] CrossProduct(this decimal[] left, decimal[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static decimal[] Normalize(this decimal[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static decimal Magnitude(this decimal[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static decimal MagnitudeSquared(this decimal[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static decimal Angle(this decimal[] first, decimal[] second)
    { return LinearAlgebra.Angle(first, second); }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static decimal[] RotateBy(this decimal[] vector, decimal angle, decimal x, decimal y, decimal z)
    { return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static decimal[] Lerp(this decimal[] left, decimal[] right, decimal blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static decimal[] Slerp(this decimal[] left, decimal[] right, decimal blend)
    { return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static decimal[] Blerp(this decimal[] a, decimal[] b, decimal[] c, decimal u, decimal v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static decimal[,] Negate(this decimal[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static decimal[,] Add(this decimal[,] left, decimal[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static decimal[,] Subtract(this decimal[,] left, decimal[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static decimal[,] Multiply(this decimal[,] left, decimal[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static decimal[,] Multiply(this decimal[,] left, decimal right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static decimal[,] Power(this decimal[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static decimal[,] Divide(this decimal[,] matrix, decimal right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static decimal[,] Minor(this decimal[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static decimal[,] ConcatenateRowWise(this decimal[,] left, decimal[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static decimal[,] Echelon(this decimal[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static decimal[,] ReducedEchelon(this decimal[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static decimal Determinent(this decimal[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static decimal[,] Inverse(this decimal[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static decimal[,] Adjoint(this decimal[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static decimal[,] Transpose(this decimal[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this decimal[,] matrix, out decimal[,] lower, out decimal[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion

    #region double

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static double[] Add(this double[] left, double[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static double[] Negate(this double[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static double[] Subtract(this double[] left, double[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static double[] Multiply(this double[] left, double right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static double[] Divide(this double[] vector, double right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static double DotProduct(this double[] left, double[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static double[] CrossProduct(this double[] left, double[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static double[] Normalize(this double[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static double Magnitude(this double[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static double MagnitudeSquared(this double[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static double Angle(this double[] first, double[] second)
    { return LinearAlgebra.Angle(first, second); }

    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static double[] RotateBy(this double[] vector, double angle, double x, double y, double z)
    { return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static double[] Lerp(this double[] left, double[] right, double blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static double[] Slerp(this double[] left, double[] right, double blend)
    { return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static double[] Blerp(this double[] a, double[] b, double[] c, double u, double v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static double[,] Negate(this double[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static double[,] Add(this double[,] left, double[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static double[,] Subtract(this double[,] left, double[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static double[,] Multiply(this double[,] left, double[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static double[,] Multiply(this double[,] left, double right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static double[,] Power(this double[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static double[,] Divide(this double[,] matrix, double right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static double[,] Minor(this double[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static double[,] ConcatenateRowWise(this double[,] left, double[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static double[,] Echelon(this double[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static double[,] ReducedEchelon(this double[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static double Determinent(this double[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static double[,] Inverse(this double[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static double[,] Adjoint(this double[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static double[,] Transpose(this double[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this double[,] matrix, out double[,] lower, out double[,] upper) 
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion

    #region float

    #region vector

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static float[] Add(this float[] left, float[] right)
    { return LinearAlgebra.Add(left, right); }
    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static float[] Negate(this float[] vector)
    { return LinearAlgebra.Negate(vector); }
    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static float[] Subtract(this float[] left, float[] right)
    { return LinearAlgebra.Subtract(left, right); }
    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static float[] Multiply(this float[] left, float right)
    { return LinearAlgebra.Multiply(left, right); }
    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static float[] Divide(this float[] vector, float right)
    { return LinearAlgebra.Divide(vector, right); }
    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static float DotProduct(this float[] left, float[] right)
    { return LinearAlgebra.DotProduct(left, right); }
    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static float[] CrossProduct(this float[] left, float[] right)
    { return LinearAlgebra.CrossProduct(left, right); }
    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static float[] Normalize(this float[] vector)
    { return LinearAlgebra.Normalize(vector); }
    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static float Magnitude(this float[] vector)
    { return LinearAlgebra.Magnitude(vector); }
    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static float MagnitudeSquared(this float[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }
    /// <summary>Computes the angle between two vectors.</summary>
    /// <param name="first">The first vector to determine the angle between.</param>
    /// <param name="second">The second vector to determine the angle between.</param>
    /// <returns>The angle between the two vectors in radians.</returns>
    public static float Angle(this float[] first, float[] second)
    { return LinearAlgebra.Angle(first, second); }
    /// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    /// <param name="vector">The vector to rotate.</param>
    /// <param name="angle">The angle of the rotation.</param>
    /// <param name="x">The x component of the axis vector to rotate about.</param>
    /// <param name="y">The y component of the axis vector to rotate about.</param>
    /// <param name="z">The z component of the axis vector to rotate about.</param>
    /// <returns>The result of the rotation.</returns>
    public static float[] RotateBy(this float[] vector, float angle, float x, float y, float z)
    { return LinearAlgebra.RotateBy(vector, angle, x, y, z); }
    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static float[] Lerp(this float[] left, float[] right, float blend)
    { return LinearAlgebra.Lerp(left, right, blend); }
    /// <summary>Sphereically interpolates between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    /// <returns>The result of the slerp operation.</returns>
    public static float[] Slerp(this float[] left, float[] right, float blend)
    { return LinearAlgebra.Slerp(left, right, blend); }
    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static float[] Blerp(this float[] a, float[] b, float[] c, float u, float v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    #endregion

    #region matrix

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static float[,] Negate(this float[,] matrix)
    { return LinearAlgebra.Negate(matrix); }
    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static float[,] Add(this float[,] left, float[,] right)
    { return LinearAlgebra.Add(left, right); }
    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static float[,] Subtract(this float[,] left, float[,] right)
    { return LinearAlgebra.Subtract(left, right); }
    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static float[,] Multiply(this float[,] left, float[,] right)
    { return LinearAlgebra.Multiply(left, right); }
    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static float[,] Multiply(this float[,] left, float right)
    { return LinearAlgebra.Multiply(left, right); }
    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static float[,] Power(this float[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }
    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static float[,] Divide(this float[,] matrix, float right)
    { return LinearAlgebra.Divide(matrix, right); }
    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static float[,] Minor(this float[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }
    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static float[,] ConcatenateRowWise(this float[,] left, float[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }
    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static float[,] Echelon(this float[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }
    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static float[,] ReducedEchelon(this float[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }
    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static float Determinent(this float[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }
    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static float[,] Inverse(this float[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }
    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static float[,] Adjoint(this float[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }
    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static float[,] Transpose(this float[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }
    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this float[,] matrix, out float[,] lower, out float[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion
    
    #endregion

    #region long

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static long[] Add(this long[] left, long[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static long[] Negate(this long[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static long[] Subtract(this long[] left, long[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static long[] Multiply(this long[] left, long right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static long[] Divide(this long[] vector, long right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static long DotProduct(this long[] left, long[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static long[] CrossProduct(this long[] left, long[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static long[] Normalize(this long[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static long Magnitude(this long[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static long MagnitudeSquared(this long[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    ///// <summary>Computes the angle between two vectors.</summary>
    ///// <param name="first">The first vector to determine the angle between.</param>
    ///// <param name="second">The second vector to determine the angle between.</param>
    ///// <returns>The angle between the two vectors in radians.</returns>
    //public static long Angle(this long[] first, long[] second)
    //{ return LinearAlgebra.Angle(first, second); }

    ///// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    ///// <param name="vector">The vector to rotate.</param>
    ///// <param name="angle">The angle of the rotation.</param>
    ///// <param name="x">The x component of the axis vector to rotate about.</param>
    ///// <param name="y">The y component of the axis vector to rotate about.</param>
    ///// <param name="z">The z component of the axis vector to rotate about.</param>
    ///// <returns>The result of the rotation.</returns>
    //public static long[] RotateBy(this long[] vector, long angle, long x, long y, long z)
    //{ return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static long[] Lerp(this long[] left, long[] right, long blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    ///// <summary>Sphereically interpolates between two vectors.</summary>
    ///// <param name="left">The starting vector of the interpolation.</param>
    ///// <param name="right">The ending vector of the interpolation.</param>
    ///// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    ///// <returns>The result of the slerp operation.</returns>
    //public static long[] Slerp(this long[] left, long[] right, long blend)
    //{ return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static long[] Blerp(this long[] a, long[] b, long[] c, long u, long v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static long[,] Negate(this long[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static long[,] Add(this long[,] left, long[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static long[,] Subtract(this long[,] left, long[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static long[,] Multiply(this long[,] left, long[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static long[,] Multiply(this long[,] left, long right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static long[,] Power(this long[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static long[,] Divide(this long[,] matrix, long right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static long[,] Minor(this long[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static long[,] ConcatenateRowWise(this long[,] left, long[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static long[,] Echelon(this long[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static long[,] ReducedEchelon(this long[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static long Determinent(this long[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static long[,] Inverse(this long[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static long[,] Adjoint(this long[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static long[,] Transpose(this long[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this long[,] matrix, out long[,] lower, out long[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion

    #region int

    /// <summary>Adds two vectors together.</summary>
    /// <param name="leftFloats">The first vector of the addition.</param>
    /// <param name="rightFloats">The second vector of the addiiton.</param>
    /// <returns>The result of the addiion.</returns>
    public static int[] Add(this int[] left, int[] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Negates all the values in a vector.</summary>
    /// <param name="vector">The vector to have its values negated.</param>
    /// <returns>The result of the negations.</returns>
    public static int[] Negate(this int[] vector)
    { return LinearAlgebra.Negate(vector); }

    /// <summary>Subtracts two vectors.</summary>
    /// <param name="left">The left vector of the subtraction.</param>
    /// <param name="right">The right vector of the subtraction.</param>
    /// <returns>The result of the vector subtracton.</returns>
    public static int[] Subtract(this int[] left, int[] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
    /// <param name="left">The vector to have the components multiplied by.</param>
    /// <param name="right">The scalars to multiply the vector components by.</param>
    /// <returns>The result of the multiplications.</returns>
    public static int[] Multiply(this int[] left, int right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Divides all the components of a vector by a scalar.</summary>
    /// <param name="vector">The vector to have the components divided by.</param>
    /// <param name="right">The scalar to divide the vector components by.</param>
    /// <returns>The resulting vector after teh divisions.</returns>
    public static int[] Divide(this int[] vector, int right)
    { return LinearAlgebra.Divide(vector, right); }

    /// <summary>Computes the dot product between two vectors.</summary>
    /// <param name="left">The first vector of the dot product operation.</param>
    /// <param name="right">The second vector of the dot product operation.</param>
    /// <returns>The result of the dot product operation.</returns>
    public static int DotProduct(this int[] left, int[] right)
    { return LinearAlgebra.DotProduct(left, right); }

    /// <summary>Computes teh cross product of two vectors.</summary>
    /// <param name="left">The first vector of the cross product operation.</param>
    /// <param name="right">The second vector of the cross product operation.</param>
    /// <returns>The result of the cross product operation.</returns>
    public static int[] CrossProduct(this int[] left, int[] right)
    { return LinearAlgebra.CrossProduct(left, right); }

    /// <summary>Normalizes a vector.</summary>
    /// <param name="vector">The vector to normalize.</param>
    /// <returns>The result of the normalization.</returns>
    public static int[] Normalize(this int[] vector)
    { return LinearAlgebra.Normalize(vector); }

    /// <summary>Computes the length of a vector.</summary>
    /// <param name="vector">The vector to calculate the length of.</param>
    /// <returns>The computed length of the vector.</returns>
    public static int Magnitude(this int[] vector)
    { return LinearAlgebra.Magnitude(vector); }

    /// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
    /// <param name="vector">The vector to compute the length squared of.</param>
    /// <returns>The computed length squared of the vector.</returns>
    public static int MagnitudeSquared(this int[] vector)
    { return LinearAlgebra.MagnitudeSquared(vector); }

    ///// <summary>Computes the angle between two vectors.</summary>
    ///// <param name="first">The first vector to determine the angle between.</param>
    ///// <param name="second">The second vector to determine the angle between.</param>
    ///// <returns>The angle between the two vectors in radians.</returns>
    //public static int Angle(this int[] first, int[] second)
    //{ return LinearAlgebra.Angle(first, second); }

    ///// <summary>Rotates a vector by the specified axis and rotation values.</summary>
    ///// <param name="vector">The vector to rotate.</param>
    ///// <param name="angle">The angle of the rotation.</param>
    ///// <param name="x">The x component of the axis vector to rotate about.</param>
    ///// <param name="y">The y component of the axis vector to rotate about.</param>
    ///// <param name="z">The z component of the axis vector to rotate about.</param>
    ///// <returns>The result of the rotation.</returns>
    //public static int[] RotateBy(this int[] vector, int angle, int x, int y, int z)
    //{ return LinearAlgebra.RotateBy(vector, angle, x, y, z); }

    /// <summary>Computes the linear interpolation between two vectors.</summary>
    /// <param name="left">The starting vector of the interpolation.</param>
    /// <param name="right">The ending vector of the interpolation.</param>
    /// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
    /// <returns>The result of the interpolation.</returns>
    public static int[] Lerp(this int[] left, int[] right, int blend)
    { return LinearAlgebra.Lerp(left, right, blend); }

    ///// <summary>Sphereically interpolates between two vectors.</summary>
    ///// <param name="left">The starting vector of the interpolation.</param>
    ///// <param name="right">The ending vector of the interpolation.</param>
    ///// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
    ///// <returns>The result of the slerp operation.</returns>
    //public static int[] Slerp(this int[] left, int[] right, int blend)
    //{ return LinearAlgebra.Slerp(left, right, blend); }

    /// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
    /// <param name="a">The first vector of the interpolation.</param>
    /// <param name="b">The second vector of the interpolation.</param>
    /// <param name="c">The thrid vector of the interpolation.</param>
    /// <param name="u">The "U" value of the barycentric interpolation equation.</param>
    /// <param name="v">The "V" value of the barycentric interpolation equation.</param>
    /// <returns>The resulting vector of the barycentric interpolation.</returns>
    public static int[] Blerp(this int[] a, int[] b, int[] c, int u, int v)
    { return LinearAlgebra.Blerp(a, b, c, u, v); }

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static int[,] Negate(this int[,] matrix)
    { return LinearAlgebra.Negate(matrix); }

    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static int[,] Add(this int[,] left, int[,] right)
    { return LinearAlgebra.Add(left, right); }

    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static int[,] Subtract(this int[,] left, int[,] right)
    { return LinearAlgebra.Subtract(left, right); }

    /// <summary>Performs multiplication on two matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static int[,] Multiply(this int[,] left, int[,] right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static int[,] Multiply(this int[,] left, int right)
    { return LinearAlgebra.Multiply(left, right); }

    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static int[,] Power(this int[,] matrix, int power)
    { return LinearAlgebra.Power(matrix, power); }

    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static int[,] Divide(this int[,] matrix, int right)
    { return LinearAlgebra.Divide(matrix, right); }

    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static int[,] Minor(this int[,] matrix, int row, int column)
    { return LinearAlgebra.Minor(matrix, row, column); }

    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static int[,] ConcatenateRowWise(this int[,] left, int[,] right)
    { return LinearAlgebra.ConcatenateRowWise(left, right); }

    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static int[,] Echelon(this int[,] matrix)
    { return LinearAlgebra.Echelon(matrix); }

    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static int[,] ReducedEchelon(this int[,] matrix)
    { return LinearAlgebra.ReducedEchelon(matrix); }

    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static int Determinent(this int[,] matrix)
    { return LinearAlgebra.Determinent(matrix); }

    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static int[,] Inverse(this int[,] matrix)
    { return LinearAlgebra.Inverse(matrix); }

    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static int[,] Adjoint(this int[,] matrix)
    { return LinearAlgebra.Adjoint(matrix); }

    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static int[,] Transpose(this int[,] matrix)
    { return LinearAlgebra.Transpose(matrix); }

    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(this int[,] matrix, out int[,] lower, out int[,] upper)
    { LinearAlgebra.DecomposeLU(matrix, out lower, out upper); }

    #endregion
  }

	/// <summary>Represents a vector with an arbitrary number of components of a generic type.</summary>
	/// <typeparam name="T">The numeric type of this Vector.</typeparam>
	public class Vector<T>
  {
    /// <summary>The array of this vector.</summary>
    public readonly T[] _vector;

    #region runtime function mapping

    private static readonly LinearAlgebra.delegates.Vector_Add<T> Vector_Add;
    private static readonly LinearAlgebra.delegates.Vector_Negate<T> Vector_Negate;
    private static readonly LinearAlgebra.delegates.Vector_Subtract<T> Vector_Subtract;
    private static readonly LinearAlgebra.delegates.Vector_Multiply<T> Vector_Multiply;
    private static readonly LinearAlgebra.delegates.Vector_Divide<T> Vector_Divide;
    private static readonly LinearAlgebra.delegates.Vector_DotProduct<T> Vector_DotProduct;
    private static readonly LinearAlgebra.delegates.Vector_CrossProduct<T> Vector_CrossProduct;
    private static readonly LinearAlgebra.delegates.Vector_Normalize<T> Vector_Normalize;
    private static readonly LinearAlgebra.delegates.Vector_Magnitude<T> Vector_Magnitude;
    private static readonly LinearAlgebra.delegates.Vector_MagnitudeSquared<T> Vector_MagnitudeSquared;
    private static readonly LinearAlgebra.delegates.Vector_Angle<T> Vector_Angle;
    private static readonly LinearAlgebra.delegates.Vector_RotateBy<T> Vector_RotateBy;
    private static readonly LinearAlgebra.delegates.Vector_Lerp<T> Vector_Lerp;
    private static readonly LinearAlgebra.delegates.Vector_Slerp<T> Vector_Slerp;
    private static readonly LinearAlgebra.delegates.Vector_Blerp<T> Vector_Blerp;
    private static readonly LinearAlgebra.delegates.Vector_EqualsValue<T> Vector_EqualsValue;
    private static readonly LinearAlgebra.delegates.Vector_EqualsValue_leniency<T> Vector_EqualsValue_leniency;
    private static readonly LinearAlgebra.delegates.Vector_RotateBy_quaternion<T> Vector_RotateBy_quaternion;

    static Vector()
    {
      LinearAlgebra<T> linearAlgebra = LinearAlgebra.Get<T>();
      Vector_Add = linearAlgebra.Vector_Add;
      Vector_Negate = linearAlgebra.Vector_Negate;
      Vector_Subtract = linearAlgebra.Vector_Subtract;
      Vector_Multiply = linearAlgebra.Vector_Multiply;
      Vector_Divide = linearAlgebra.Vector_Divide;
      Vector_DotProduct = linearAlgebra.Vector_DotProduct;
      Vector_CrossProduct = linearAlgebra.Vector_CrossProduct;
      Vector_Normalize = linearAlgebra.Vector_Normalize;
      Vector_Magnitude = linearAlgebra.Vector_Magnitude;
      Vector_MagnitudeSquared = linearAlgebra.Vector_MagnitudeSquared;
      Vector_Angle = linearAlgebra.Vector_Angle;
      Vector_RotateBy = linearAlgebra.Vector_RotateBy;
      Vector_Lerp = linearAlgebra.Vector_Lerp;
      Vector_Slerp = linearAlgebra.Vector_Slerp;
      Vector_Blerp = linearAlgebra.Vector_Blerp;
      Vector_EqualsValue = linearAlgebra.Vector_EqualsValue;
      Vector_EqualsValue_leniency = linearAlgebra.Vector_EqualsValue_leniency;
      Vector_RotateBy_quaternion = linearAlgebra.Vector_RotateBy_quaternion;
    }

    #endregion

    #region properties

    /// <summary>Sane as accessing index 0.</summary>
		public T X
		{
			get { return _vector[0]; }
			set { _vector[0] = value; }
		}

		/// <summary>Same as accessing index 1.</summary>
		public T Y
		{
			get { try { return _vector[1]; } catch { throw new Error("vector does not contains a y component."); } }
			set { try { _vector[1] = value; } catch { throw new Error("vector does not contains a y component."); } }
		}

		/// <summary>Same as accessing index 2.</summary>
		public T Z
		{
			get { try { return _vector[2]; } catch { throw new Error("vector does not contains a z component."); } }
			set { try { _vector[2] = value; } catch { throw new Error("vector does not contains a z component."); } }
		}

		/// <summary>Same as accessing index 3.</summary>
		public T W
		{
			get { try { return _vector[3]; } catch { throw new Error("vector does not contains a w component."); } }
			set { try { _vector[3] = value; } catch { throw new Error("vector does not contains a w component."); } }
		}
		
		/// <summary>The number of components in this vector.</summary>
		public int Dimensions { get { return _vector.Length; } }

		/// <summary>Allows indexed access to this vector.</summary>
		/// <param name="index">The index to access.</param>
		/// <returns>The value of the given index.</returns>
		public T this[int index]
		{
			get { try { return _vector[index]; } catch { throw new Error("index out of bounds."); } }
			set { try { _vector[index] = value; } catch { throw new Error("index out of bounds."); } }
		}

    #endregion

    #region constructors

    /// <summary>Creates a new vector with the given number of components.</summary>
		/// <param name="dimensions">The number of dimensions this vector will have.</param>
		public Vector(int dimensions) { try { _vector = new T[dimensions]; } catch { throw new Error("invalid dimensions on vector contruction."); } }

		/// <summary>Creates a vector out of the given values.</summary>
		/// <param name="vector">The values to initialize the vector to.</param>
		public Vector(params T[] vector) { _vector = vector; }

    #endregion

    #region factories

    /// <summary>Creates a vector with the given number of components with the values initialized to zeroes.</summary>
		/// <param name="dimensions">The number of components in the vector.</param>
		/// <returns>The newly constructed vector.</returns>
		public static Vector<T> FactoryZero(int dimensions) { return new Vector<T>(dimensions); }

		/// <summary>Creates a vector with the given number of components with the values initialized to ones.</summary>
		/// <param name="dimensions">The number of components in the vector.</param>
		/// <returns>The newly constructed vector.</returns>
		public static Vector<T> FactoryOne(int dimensions) { return new Vector<T>(new T[dimensions]); }

    ///// <summary>Returns a 3-component vector representing the x-axis.</summary>
    //public static readonly Vector<T> Factory_XAxis = new Vector<T>(_one, _zero, _zero);
    ///// <summary>Returns a 3-component vector representing the y-axis.</summary>
    //public static readonly Vector<T> Factory_YAxis = new Vector<T>(_zero, _one, _zero);
    ///// <summary>Returns a 3-component vector representing the z-axis.</summary>
    //public static readonly Vector<T> Factory_ZAxis = new Vector<T>(_zero, _zero, _one);
    ///// <summary>Returns a 3-component vector representing the negative x-axis.</summary>
    //public static readonly Vector<T> Factory_NegXAxis = new Vector<T>(_one, _zero, _zero);
    ///// <summary>Returns a 3-component vector representing the negative y-axis.</summary>
    //public static readonly Vector<T> Factory_NegYAxis = new Vector<T>(_zero, _one, _zero);
    ///// <summary>Returns a 3-component vector representing the negative z-axis.</summary>
    //public static readonly Vector<T> Factory_NegZAxis = new Vector<T>(_zero, _zero, _one);

    #endregion

    #region operator

    /// <summary>Adds two vectors together.</summary>
		/// <param name="left">The first vector of the addition.</param>
		/// <param name="right">The second vector of the addition.</param>
		/// <returns>The result of the addition.</returns>
		public static Vector<T> operator +(Vector<T> left, Vector<T> right)
    { return Vector_Add(left, right); }
		/// <summary>Subtracts two vectors.</summary>
		/// <param name="left">The left operand of the subtraction.</param>
		/// <param name="right">The right operand of the subtraction.</param>
		/// <returns>The result of the subtraction.</returns>
		public static Vector<T> operator -(Vector<T> left, Vector<T> right)
    { return Vector_Subtract(left, right); }
		/// <summary>Negates a vector.</summary>
		/// <param name="vector">The vector to negate.</param>
		/// <returns>The result of the negation.</returns>
		public static Vector<T> operator -(Vector<T> vector)
    { return Vector_Negate(vector); }
		/// <summary>Multiplies all the values in a vector by a scalar.</summary>
		/// <param name="left">The vector to have all its values multiplied.</param>
		/// <param name="right">The scalar to multiply all the vector values by.</param>
		/// <returns>The result of the multiplication.</returns>
		public static Vector<T> operator *(Vector<T> left, T right)
    { return Vector_Multiply(left, right); }
		/// <summary>Multiplies all the values in a vector by a scalar.</summary>
		/// <param name="left">The scalar to multiply all the vector values by.</param>
		/// <param name="right">The vector to have all its values multiplied.</param>
		/// <returns>The result of the multiplication.</returns>
		public static Vector<T> operator *(T left, Vector<T> right)
    { return Vector_Multiply(right, left); }
		/// <summary>Divides all the values in the vector by a scalar.</summary>
		/// <param name="left">The vector to have its values divided.</param>
		/// <param name="right">The scalar to divide all the vectors values by.</param>
		/// <returns>The vector after the divisions.</returns>
		public static Vector<T> operator /(Vector<T> left, T right)
    { return Vector_Divide(left, right); }
		/// <summary>Does an equality check by value. (warning for float errors)</summary>
		/// <param name="left">The first vector of the equality check.</param>
		/// <param name="right">The second vector of the equality check.</param>
		/// <returns>true if the values are equal, false if not.</returns>
		public static bool operator ==(Vector<T> left, Vector<T> right)
    { return Vector_EqualsValue(left, right); }
		/// <summary>Does an anti-equality check by value. (warning for float errors)</summary>
		/// <param name="left">The first vector of the anit-equality check.</param>
		/// <param name="right">The second vector of the anti-equality check.</param>
		/// <returns>true if the values are not equal, false if they are.</returns>
		public static bool operator !=(Vector<T> left, Vector<T> right)
    { return !Vector_EqualsValue(left, right); }
		/// <summary>Implicit conversions from Vector to T[].</summary>
		/// <param name="vector">The Vector to be converted to a T[].</param>
		/// <returns>The T[] of the vector.</returns>
		public static implicit operator T[](Vector<T> vector)
    { return vector._vector; }
		/// <summary>Implicit conversions from Vector to T[].</summary>
		/// <param name="array">The Vector to be converted to a T[].</param>
		/// <returns>The T[] of the vector.</returns>
		public static implicit operator Vector<T>(T[] array)
    { return new Vector<T>(array); }
    /// <summary>Converts a vector into a matrix.</summary>
    /// <param name="vector">The vector to convert.</param>
    /// <returns>The resulting matrix.</returns>
    public static explicit operator Matrix<T>(Vector<T> vector)
    {
      T[,] matrix = new T[1,vector.Dimensions];
      for (int i = 0; i < vector.Dimensions; i++)
        matrix[0, i] = vector[i];
      return new Matrix<T>(matrix);
    }

    #endregion

    #region instance

    /// <summary>Adds two vectors together.</summary>
		/// <param name="right">The vector to add to this one.</param>
		/// <returns>The result of the vector.</returns>
		public Vector<T> Add(Vector<T> right)
    { return Vector_Add(this, right); }
		/// <summary>Negates this vector.</summary>
		/// <returns>The result of the negation.</returns>
		public Vector<T> Negate()
    { return Vector_Negate(this); }
		/// <summary>Subtracts another vector from this one.</summary>
		/// <param name="right">The vector to subtract from this one.</param>
		/// <returns>The result of the subtraction.</returns>
		public Vector<T> Subtract(Vector<T> right)
    { return Vector_Subtract(this, right); }
		/// <summary>Multiplies the values in this vector by a scalar.</summary>
		/// <param name="right">The scalar to multiply these values by.</param>
		/// <returns>The result of the multiplications</returns>
		public Vector<T> Multiply(T right)
    { return Vector_Multiply(this, right); }
		/// <summary>Divides all the values in this vector by a scalar.</summary>
		/// <param name="right">The scalar to divide the values of the vector by.</param>
		/// <returns>The resulting vector after teh divisions.</returns>
		public Vector<T> Divide(T right)
    { return Vector_Divide(this, right); }
		/// <summary>Computes the dot product between this vector and another.</summary>
		/// <param name="right">The second vector of the dot product operation.</param>
		/// <returns>The result of the dot product.</returns>
		public T DotProduct(Vector<T> right)
    { return Vector_DotProduct(this, right); }
		/// <summary>Computes the cross product between this vector and another.</summary>
		/// <param name="right">The second vector of the dot product operation.</param>
		/// <returns>The result of the dot product operation.</returns>
		public Vector<T> CrossProduct(Vector<T> right)
    { return Vector_CrossProduct(this, right); }
		/// <summary>Normalizes this vector.</summary>
		/// <returns>The result of the normalization.</returns>
		public Vector<T> Normalize()
    { return Vector_Normalize(this); }
		/// <summary>Computes the length of this vector.</summary>
		/// <returns>The length of this vector.</returns>
		public T Magnitude()
    { return Vector_Magnitude(this); }
		/// <summary>Computes the length of this vector, but doesn't square root it for 
		/// possible optimization purposes.</summary>
		/// <returns>The squared length of the vector.</returns>
		public T MagnitudeSquared()
    { return Vector_MagnitudeSquared(this); }
		/// <summary>Check for equality by value.</summary>
		/// <param name="right">The other vector of the equality check.</param>
		/// <returns>true if the values were equal, false if not.</returns>
		public bool EqualsValue(Vector<T> right)
    { return Vector_EqualsValue(this, right); }
		/// <summary>Checks for equality by value with some leniency.</summary>
		/// <param name="right">The other vector of the equality check.</param>
		/// <param name="leniency">The ammount the values can differ but still be considered equal.</param>
		/// <returns>true if the values were cinsidered equal, false if not.</returns>
		public bool EqualsValue(Vector<T> right, T leniency)
    { return Vector_EqualsValue_leniency(this, right, leniency); }
		/// <summary>Checks for equality by reference.</summary>
		/// <param name="right">The other vector of the equality check.</param>
		/// <returns>true if the references are equal, false if not.</returns>
		public bool EqualsReference(Vector<T> right)
    { return Vector<T>.EqualsReference(this, right); }
		/// <summary>Rotates this vector by quaternon values.</summary>
		/// <param name="angle">The amount of rotation about the axis.</param>
		/// <param name="x">The x component deterniming the axis of rotation.</param>
		/// <param name="y">The y component determining the axis of rotation.</param>
		/// <param name="z">The z component determining the axis of rotation.</param>
		/// <returns>The resulting vector after the rotation.</returns>
		public Vector<T> RotateBy(T angle, T x, T y, T z)
    { return Vector_RotateBy(this, angle, x, y, z); }
		/// <summary>Computes the linear interpolation between two vectors.</summary>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
		/// <returns>The result of the interpolation.</returns>
		public Vector<T> Lerp(Vector<T> right, T blend)
    { return Vector_Lerp(this, right, blend); }
		/// <summary>Sphereically interpolates between two vectors.</summary>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
		/// <returns>The result of the slerp operation.</returns>
		public Vector<T> Slerp(Vector<T> right, T blend)
    { return Vector_Slerp(this, right, blend); }
		/// <summary>Rotates a vector by a quaternion.</summary>
		/// <param name="rotation">The quaternion to rotate the 3-component vector by.</param>
		/// <returns>The result of the rotation.</returns>
    public Vector<T> RotateBy(Quaternion<T> rotation)
    { return Vector_RotateBy_quaternion(this, rotation); }

    #endregion

    #region static

    /// <summary>Adds two vectors together.</summary>
		/// <param name="left">The first vector of the addition.</param>
		/// <param name="right">The second vector of the addiiton.</param>
		/// <returns>The result of the addiion.</returns>
		public static Vector<T> Add(T[] left, T[] right)
    { return Vector_Add(left, right); }
		/// <summary>Adds two vectors together.</summary>
		/// <param name="left">The first vector of the addition.</param>
		/// <param name="right">The second vector of the addiiton.</param>
		/// <returns>The result of the addiion.</returns>
		public static Vector<T> Add(Vector<T> left, Vector<T> right)
    { return Vector_Add(left._vector, right._vector); }
		/// <summary>Negates all the values in a vector.</summary>
		/// <param name="vector">The vector to have its values negated.</param>
		/// <returns>The result of the negations.</returns>
		public static T[] Negate(T[] vector)
    { return Vector_Negate(vector); }
		/// <summary>Negates all the values in a vector.</summary>
		/// <param name="vector">The vector to have its values negated.</param>
		/// <returns>The result of the negations.</returns>
		public static Vector<T> Negate(Vector<T> vector)
    { return Vector_Negate(vector); }
		/// <summary>Subtracts two vectors.</summary>
		/// <param name="left">The left vector of the subtraction.</param>
		/// <param name="right">The right vector of the subtraction.</param>
		/// <returns>The result of the vector subtracton.</returns>
		public static T[] Subtract(T[] left, T[] right)
    { return Vector_Subtract(left, right); }
		/// <summary>Subtracts two vectors.</summary>
		/// <param name="left">The left vector of the subtraction.</param>
		/// <param name="right">The right vector of the subtraction.</param>
		/// <returns>The result of the vector subtracton.</returns>
		public static Vector<T> Subtract(Vector<T> left, Vector<T> right)
    { return Vector_Subtract(left._vector, right._vector); }
		/// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
		/// <param name="left">The vector to have the components multiplied by.</param>
		/// <param name="right">The scalars to multiply the vector components by.</param>
		/// <returns>The result of the multiplications.</returns>
		public static T[] Multiply(T[] left, T right)
    { return Vector_Multiply(left, right); }
		/// <summary>Multiplies all the components of a vecotr by a scalar.</summary>
		/// <param name="left">The vector to have the components multiplied by.</param>
		/// <param name="right">The scalars to multiply the vector components by.</param>
		/// <returns>The result of the multiplications.</returns>
		public static Vector<T> Multiply(Vector<T> left, T right)
    { return Vector_Multiply(left._vector, right); }
		/// <summary>Divides all the components of a vector by a scalar.</summary>
		/// <param name="left">The vector to have the components divided by.</param>
		/// <param name="right">The scalar to divide the vector components by.</param>
		/// <returns>The resulting vector after teh divisions.</returns>
		public static T[] Divide(T[] left, T right)
    { return Vector_Divide(left, right); }
		/// <summary>Divides all the components of a vector by a scalar.</summary>
		/// <param name="left">The vector to have the components divided by.</param>
		/// <param name="right">The scalar to divide the vector components by.</param>
		/// <returns>The resulting vector after teh divisions.</returns>
		public static Vector<T> Divide(Vector<T> left, T right)
    { return Vector_Divide(left, right); }
		/// <summary>Computes the dot product between two vectors.</summary>
		/// <param name="left">The first vector of the dot product operation.</param>
		/// <param name="right">The second vector of the dot product operation.</param>
		/// <returns>The result of the dot product operation.</returns>
		public static T DotProduct(T[] left, T[] right)
    { return Vector_DotProduct(left, right); }
		/// <summary>Computes the dot product between two vectors.</summary>
		/// <param name="left">The first vector of the dot product operation.</param>
		/// <param name="right">The second vector of the dot product operation.</param>
		/// <returns>The result of the dot product operation.</returns>
		public static T DotProduct(Vector<T> left, Vector<T> right)
    { return Vector_DotProduct(left._vector, right._vector); }
		/// <summary>Computes teh cross product of two vectors.</summary>
		/// <param name="left">The first vector of the cross product operation.</param>
		/// <param name="right">The second vector of the cross product operation.</param>
		/// <returns>The result of the cross product operation.</returns>
		public static T[] CrossProduct(T[] left, T[] right)
    { return Vector_CrossProduct(left, right); }
		/// <summary>Computes teh cross product of two vectors.</summary>
		/// <param name="left">The first vector of the cross product operation.</param>
		/// <param name="right">The second vector of the cross product operation.</param>
		/// <returns>The result of the cross product operation.</returns>
		public static Vector<T> CrossProduct(Vector<T> left, Vector<T> right)
    { return Vector_CrossProduct(left, right); }
		/// <summary>Normalizes a vector.</summary>
		/// <param name="vector">The vector to normalize.</param>
		/// <returns>The result of the normalization.</returns>
		public static T[] Normalize(T[] vector)
    { return Vector_Normalize(vector); }
		/// <summary>Normalizes a vector.</summary>
		/// <param name="vector">The vector to normalize.</param>
		/// <returns>The result of the normalization.</returns>
		public static Vector<T> Normalize(Vector<T> vector)
    { return Vector_Normalize(vector._vector); }
		/// <summary>Computes the length of a vector.</summary>
		/// <param name="vector">The vector to calculate the length of.</param>
		/// <returns>The computed length of the vector.</returns>
		public static T Magnitude(T[] vector)
    { return Vector_Magnitude(vector); }
		/// <summary>Computes the length of a vector.</summary>
		/// <param name="vector">The vector to calculate the length of.</param>
		/// <returns>The computed length of the vector.</returns>
		public static T Magnitude(Vector<T> vector)
    { return Vector_Magnitude(vector); }
		/// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
		/// <param name="vector">The vector to compute the length squared of.</param>
		/// <returns>The computed length squared of the vector.</returns>
    public static T MagnitudeSquared(T[] vector)
    { return Vector_MagnitudeSquared(vector); }
		/// <summary>Computes the length of a vector but doesn't square root it for efficiency (length remains squared).</summary>
		/// <param name="vector">The vector to compute the length squared of.</param>
		/// <returns>The computed length squared of the vector.</returns>
    public static T MagnitudeSquared(Vector<T> vector)
    { return Vector_MagnitudeSquared(vector._vector); }
		/// <summary>Computes the angle between two vectors.</summary>
		/// <param name="first">The first vector to determine the angle between.</param>
		/// <param name="second">The second vector to determine the angle between.</param>
		/// <returns>The angle between the two vectors in radians.</returns>
		public static T Angle(T[] first, T[] second)
    { return Vector_Angle(first, second); }
		/// <summary>Computes the angle between two vectors.</summary>
		/// <param name="first">The first vector to determine the angle between.</param>
		/// <param name="second">The second vector to determine the angle between.</param>
		/// <returns>The angle between the two vectors in radians.</returns>
		public static T Angle(Vector<T> first, Vector<T> second)
    { return Vector_Angle(first._vector, second._vector); }
		/// <summary>Rotates a vector by the specified axis and rotation values.</summary>
		/// <param name="vector">The vector to rotate.</param>
		/// <param name="angle">The angle of the rotation.</param>
		/// <param name="x">The x component of the axis vector to rotate about.</param>
		/// <param name="y">The y component of the axis vector to rotate about.</param>
		/// <param name="z">The z component of the axis vector to rotate about.</param>
		/// <returns>The result of the rotation.</returns>
		public static T[] RotateBy(T[] vector, T angle, T x, T y, T z)
    { return Vector_RotateBy(vector, angle, x, y, z); }
		/// <summary>Rotates a vector by the specified axis and rotation values.</summary>
		/// <param name="vector">The vector to rotate.</param>
		/// <param name="angle">The angle of the rotation.</param>
		/// <param name="x">The x component of the axis vector to rotate about.</param>
		/// <param name="y">The y component of the axis vector to rotate about.</param>
		/// <param name="z">The z component of the axis vector to rotate about.</param>
		/// <returns>The result of the rotation.</returns>
		public static Vector<T> RotateBy(Vector<T> vector, T angle, T x, T y, T z)
    { return Vector_RotateBy(vector._vector, angle, x, y, z); }
		/// <summary>Rotates a vector by a quaternion.</summary>
		/// <param name="vector">The vector to rotate.</param>
		/// <param name="rotation">The quaternion to rotate the 3-component vector by.</param>
		/// <returns>The result of the rotation.</returns>
		public static Vector<T> RotateBy(Vector<T> vector, Quaternion<T> rotation)
    { return Vector_RotateBy_quaternion(vector._vector, rotation); }
		/// <summary>Computes the linear interpolation between two vectors.</summary>
		/// <param name="left">The starting vector of the interpolation.</param>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
		/// <returns>The result of the interpolation.</returns>
		public static T[] Lerp(T[] left, T[] right, T blend)
    { return Vector_Lerp(left, right, blend); }
		/// <summary>Computes the linear interpolation between two vectors.</summary>
		/// <param name="left">The starting vector of the interpolation.</param>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 of the interpolation between the start and end.</param>
		/// <returns>The result of the interpolation.</returns>
		public static Vector<T> Lerp(Vector<T> left, Vector<T> right, T blend)
    { return Vector_Lerp(left._vector, right._vector, blend); }
		/// <summary>Sphereically interpolates between two vectors.</summary>
		/// <param name="left">The starting vector of the interpolation.</param>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
		/// <returns>The result of the slerp operation.</returns>
		public static T[] Slerp(T[] left, T[] right, T blend)
    { return Vector_Slerp(left, right, blend); }
		/// <summary>Sphereically interpolates between two vectors.</summary>
		/// <param name="left">The starting vector of the interpolation.</param>
		/// <param name="right">The ending vector of the interpolation.</param>
		/// <param name="blend">The ratio 0.0 to 1.0 defining the interpolation distance between the two vectors.</param>
		/// <returns>The result of the slerp operation.</returns>
		public static Vector<T> Slerp(Vector<T> left, Vector<T> right, T blend)
    { return Vector_Slerp(left._vector, right._vector, blend); }
		/// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
		/// <param name="a">The first vector of the interpolation.</param>
		/// <param name="b">The second vector of the interpolation.</param>
		/// <param name="c">The thrid vector of the interpolation.</param>
		/// <param name="u">The "U" value of the barycentric interpolation equation.</param>
		/// <param name="v">The "V" value of the barycentric interpolation equation.</param>
		/// <returns>The resulting vector of the barycentric interpolation.</returns>
		public static T[] Blerp(T[] a, T[] b, T[] c, T u, T v)
    { return Vector_Blerp(a, b, c, u, v); }
		/// <summary>Interpolates between three vectors using barycentric coordinates.</summary>
		/// <param name="a">The first vector of the interpolation.</param>
		/// <param name="b">The second vector of the interpolation.</param>
		/// <param name="c">The thrid vector of the interpolation.</param>
		/// <param name="u">The "U" value of the barycentric interpolation equation.</param>
		/// <param name="v">The "V" value of the barycentric interpolation equation.</param>
		/// <returns>The resulting vector of the barycentric interpolation.</returns>
		public static Vector<T> Blerp(Vector<T> a, Vector<T> b, Vector<T> c, T u, T v)
    { return Vector_Blerp(a._vector, b._vector, c._vector, u, v); }
		/// <summary>Does a value equality check.</summary>
		/// <param name="left">The first vector to check for equality.</param>
		/// <param name="right">The second vector  to check for equality.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public static bool EqualsValue(T[] left, T[] right)
    { return Vector_EqualsValue(left, right); }
		/// <summary>Does a value equality check.</summary>
		/// <param name="left">The first vector to check for equality.</param>
		/// <param name="right">The second vector  to check for equality.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public static bool EqualsValue(Vector<T> left, Vector<T> right)
    { return Vector_EqualsValue(left._vector, right._vector); }
		/// <summary>Does a value equality check with leniency.</summary>
		/// <param name="left">The first vector to check for equality.</param>
		/// <param name="right">The second vector to check for equality.</param>
		/// <param name="leniency">How much the values can vary but still be considered equal.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public static bool EqualsValue(T[] left, T[] right, T leniency)
    { return Vector_EqualsValue_leniency(left, right, leniency); }
		/// <summary>Does a value equality check with leniency.</summary>
		/// <param name="left">The first vector to check for equality.</param>
		/// <param name="right">The second vector to check for equality.</param>
		/// <param name="leniency">How much the values can vary but still be considered equal.</param>
		/// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsValue(Vector<T> left, Vector<T> right, T leniency)
    { return Vector_EqualsValue_leniency(left._vector, right._vector, leniency); }
    /// <summary>Checks if two matrices are equal by reverences.</summary>
		/// <param name="left">The left vector of the equality check.</param>
		/// <param name="right">The right vector of the equality check.</param>
		/// <returns>True if the references are equal, false if not.</returns>
		public static bool EqualsReference(T[] left, T[] right)
    { return object.ReferenceEquals(left, right); }
		/// <summary>Checks if two matrices are equal by reverences.</summary>
		/// <param name="left">The left vector of the equality check.</param>
		/// <param name="right">The right vector of the equality check.</param>
		/// <returns>True if the references are equal, false if not.</returns>
		public static bool EqualsReference(Vector<T> left, Vector<T> right)
		{ return EqualsReference(left._vector, right._vector); }

    #endregion

    #region override

    /// <summary>Prints out a string representation of this matrix.</summary>
		/// <returns>A string representing this matrix.</returns>
		public override string ToString()
		{ return base.ToString(); }
		/// <summary>Computes a hash code from the values of this matrix.</summary>
		/// <returns>A hash code for the matrix.</returns>
		public override int GetHashCode()
    { return this._vector.GetHashCode(); }
		/// <summary>Does an equality check by reference.</summary>
		/// <param name="right">The object to compare to.</param>
		/// <returns>True if the references are equal, false if not.</returns>
		public override bool Equals(object right)
		{
			if (!(right is Vector<T>)) return false;
			return Vector<T>.EqualsReference(this, (Vector<T>)right);
    }

    #endregion
  }

  /// <summary>Standard 4-component quaternion [x, y, z, w]. W is the rotation ammount.</summary>
	/// <typeparam name="T">The numeric type of this Quaternion.</typeparam>
	public class Quaternion<T>
  {
    // the values of the quaternion
    protected T _x, _y, _z, _w;

    #region runtime function mapping

    private static LinearAlgebra.delegates.Quaternion_Magnitude<T> _Quaternion_Magnitude;
    private static LinearAlgebra.delegates.Quaternion_MagnitudeSquared<T> Quaternion_MagnitudeSquared;
    private static LinearAlgebra.delegates.Quaternion_Conjugate<T> _Quaternion_Conjugate;
    private static LinearAlgebra.delegates.Quaternion_Add<T> _Quaternion_Add;
    private static LinearAlgebra.delegates.Quaternion_Subtract<T> _Quaternion_Subtract;
    private static LinearAlgebra.delegates.Quaternion_Multiply<T> _Quaternion_Multiply;
    private static LinearAlgebra.delegates.Quaternion_Multiply_scalar<T> _Quaternion_Multiply_scalar;
    private static LinearAlgebra.delegates.Quaternion_Multiply_Vector<T> _Quaternion_Multiply_Vector;
    private static LinearAlgebra.delegates.Quaternion_Normalize<T> _Quaternion_Normalize;
    private static LinearAlgebra.delegates.Quaternion_Invert<T> _Quaternion_Invert;
    private static LinearAlgebra.delegates.Quaternion_Lerp<T> _Quaternion_Lerp;
    private static LinearAlgebra.delegates.Quaternion_Slerp<T> _Quaternion_Slerp;
    private static LinearAlgebra.delegates.Quaternion_Rotate<T> _Quaternion_Rotate;
    private static LinearAlgebra.delegates.Quaternion_EqualsValue<T> _Quaternion_EqualsValue;
    private static LinearAlgebra.delegates.Quaternion_EqualsValue_leniency<T> _Quaternion_EqualsValue_leniency;

    // Constants
    private static T _zero;
    private static T _one;
    private static T _two;

    static Quaternion()
    {
      // Constants
		  _zero = Constants.Get<T>().factory(0);
		  _one = Constants.Get<T>().factory(1);
		  _two = Constants.Get<T>().factory(2);

      LinearAlgebra<T> linearAlgebra = LinearAlgebra.Get<T>();
      _Quaternion_Magnitude = linearAlgebra.Quaternion_Magnitude;
      Quaternion_MagnitudeSquared = linearAlgebra.Quaternion_MagnitudeSquared;
      _Quaternion_Conjugate = linearAlgebra.Quaternion_Conjugate;
      _Quaternion_Add = linearAlgebra.Quaternion_Add;
      _Quaternion_Subtract = linearAlgebra.Quaternion_Subtract;
      _Quaternion_Multiply = linearAlgebra.Quaternion_Multiply;
      _Quaternion_Multiply_scalar = linearAlgebra.Quaternion_Multiply_scalar;
      _Quaternion_Multiply_Vector = linearAlgebra.Quaternion_Multiply_Vector;
      _Quaternion_Normalize = linearAlgebra.Quaternion_Normalize;
      _Quaternion_Invert = linearAlgebra.Quaternion_Invert;
      _Quaternion_Lerp = linearAlgebra.Quaternion_Lerp;
      _Quaternion_Slerp = linearAlgebra.Quaternion_Slerp;
      _Quaternion_Rotate = linearAlgebra.Quaternion_Rotate;
      _Quaternion_EqualsValue = linearAlgebra.Quaternion_EqualsValue;
      _Quaternion_EqualsValue_leniency = linearAlgebra.Quaternion_EqualsValue_leniency;
    }

    #endregion

    #region property

		/// <summary>The X component of the quaternion. (axis, NOT rotation ammount)</summary>
		public T X { get { return _x; } set { _x = value; } }
		/// <summary>The Y component of the quaternion. (axis, NOT rotation ammount)</summary>
		public T Y { get { return _y; } set { _y = value; } }
		/// <summary>The Z component of the quaternion. (axis, NOT rotation ammount)</summary>
		public T Z { get { return _z; } set { _z = value; } }
		/// <summary>The W component of the quaternion. (rotation ammount, NOT axis)</summary>
		public T W { get { return _w; } set { _w = value; } }

    #endregion

    #region constructor

    /// <summary>Constructs a quaternion with the desired values.</summary>
		/// <param name="x">The x component of the quaternion.</param>
		/// <param name="y">The y component of the quaternion.</param>
		/// <param name="z">The z component of the quaternion.</param>
		/// <param name="w">The w component of the quaternion.</param>
		public Quaternion(T x, T y, T z, T w) { _x = x; _y = y; _z = z; _w = w; }

    #endregion

    #region factories

    /// <summary>Returns new Quaternion(0, 0, 0, 1).</summary>
		public static readonly Quaternion<T> FactoryIdentity = new Quaternion<T>(_zero, _zero, _zero, _one);

		///// <summary>Creates a quaternion from an axis and rotation.</summary>
		///// <param name="axis">The to create the quaternion from.</param>
		///// <param name="angle">The angle to create teh quaternion from.</param>
		///// <returns>The newly created quaternion.</returns>
		//public static Quaternion<T> FactoryFromAxisAngle(Vector axis, T angle)
		//{
		//	throw new System.NotImplementedException();
		//	//if (axis.LengthSquared() == 0.0f)
		//	//	return FactoryIdentity;
		//	//T sinAngleOverAxisLength = Calc.Sin(angle / 2) / axis.Length();
		//	//return Quaternion<T>.Normalize(new Quaternion<T>(
		//	//	_multiply(axis.X, sinAngleOverAxisLength),
		//	//	axis.Y * sinAngleOverAxisLength,
		//	//	axis.Z * sinAngleOverAxisLength,
		//	//	Calc.Cos(angle / 2)));
    //}

    #endregion

    #region operator

    /// <summary>Adds two quaternions together.</summary>
		/// <param name="left">The first quaternion of the addition.</param>
		/// <param name="right">The second quaternion of the addition.</param>
		/// <returns>The result of the addition.</returns>
		public static Quaternion<T> operator +(Quaternion<T> left, Quaternion<T> right)
    { return Quaternion<T>.Add(left, right); }
		/// <summary>Subtracts two quaternions.</summary>
		/// <param name="left">The left quaternion of the subtraction.</param>
		/// <param name="right">The right quaternion of the subtraction.</param>
		/// <returns>The resulting quaternion after the subtraction.</returns>
		public static Quaternion<T> operator -(Quaternion<T> left, Quaternion<T> right)
    { return Quaternion<T>.Subtract(left, right); }
		/// <summary>Multiplies two quaternions together.</summary>
		/// <param name="left">The first quaternion of the multiplication.</param>
		/// <param name="right">The second quaternion of the multiplication.</param>
		/// <returns>The resulting quaternion after the multiplication.</returns>
		public static Quaternion<T> operator *(Quaternion<T> left, Quaternion<T> right)
    { return Quaternion<T>.Multiply(left, right); }
		/// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
		/// <param name="left">The quaternion to pre-multiply the vector by.</param>
		/// <param name="vector">The vector to be multiplied.</param>
		/// <returns>The resulting quaternion of the multiplication.</returns>
		//public static Quaternion<T> operator *(Quaternion<T> left, Vector right)
    //{ return Quaternion<T>.Multiply(left, right); }
		/// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
		/// <param name="left">The quaternion of the multiplication.</param>
		/// <param name="right">The scalar of the multiplication.</param>
		/// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
		public static Quaternion<T> operator *(Quaternion<T> left, T right)
    { return Quaternion<T>.Multiply(left, right); }
		/// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
		/// <param name="left">The scalar of the multiplication.</param>
		/// <param name="right">The quaternion of the multiplication.</param>
		/// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
		public static Quaternion<T> operator *(T left, Quaternion<T> right)
    { return Quaternion<T>.Multiply(right, left); }
		/// <summary>Checks for equality by value. (beware float errors)</summary>
		/// <param name="left">The first quaternion of the equality check.</param>
		/// <param name="right">The second quaternion of the equality check.</param>
		/// <returns>true if the values were deemed equal, false if not.</returns>
		public static bool operator ==(Quaternion<T> left, Quaternion<T> right)
    { return Quaternion<T>.Equals(left, right); }
		/// <summary>Checks for anti-equality by value. (beware float errors)</summary>
		/// <param name="left">The first quaternion of the anti-equality check.</param>
		/// <param name="right">The second quaternion of the anti-equality check.</param>
		/// <returns>false if the values were deemed equal, true if not.</returns>
		public static bool operator !=(Quaternion<T> left, Quaternion<T> right)
    { return !Quaternion<T>.Equals(left, right); }

    #endregion

    #region instance

    /// <summary>Computes the length of quaternion.</summary>
		/// <returns>The length of the given quaternion.</returns>
		public T Magnitude() { return Quaternion<T>.Magnitude(this); }
		/// <summary>Computes the length of a quaternion, but doesn't square root it
		/// for optimization possibilities.</summary>
		/// <returns>The squared length of the given quaternion.</returns>
		public T MagnitudeSquared() { return Quaternion<T>.MagnitudeSquared(this); }
		/// <summary>Gets the conjugate of the quaternion.</summary>
		/// <returns>The conjugate of teh given quaternion.</returns>
		public Quaternion<T> Conjugate() { return Quaternion<T>.Conjugate(this); }
		/// <summary>Adds two quaternions together.</summary>
		/// <param name="right">The second quaternion of the addition.</param>
		/// <returns>The result of the addition.</returns>
		public Quaternion<T> Add(Quaternion<T> right) { return Quaternion<T>.Add(this, right); }
		/// <summary>Subtracts two quaternions.</summary>
		/// <param name="right">The right quaternion of the subtraction.</param>
		/// <returns>The resulting quaternion after the subtraction.</returns>
		public Quaternion<T> Subtract(Quaternion<T> right) { return Quaternion<T>.Subtract(this, right); }
		/// <summary>Multiplies two quaternions together.</summary>
		/// <param name="right">The second quaternion of the multiplication.</param>
		/// <returns>The resulting quaternion after the multiplication.</returns>
		public Quaternion<T> Multiply(Quaternion<T> right) { return Quaternion<T>.Multiply(this, right); }
		/// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
		/// <param name="right">The scalar of the multiplication.</param>
		/// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
		public Quaternion<T> Multiply(T right) { return Quaternion<T>.Multiply(this, right); }
		/// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
		/// <param name="right">The vector to be multiplied.</param>
		/// <returns>The resulting quaternion of the multiplication.</returns>
		//public Quaternion<T> Multiply(Vector vector) { return Quaternion<T>.Multiply(this, vector); }
		/// <summary>Normalizes the quaternion.</summary>
		/// <returns>The normalization of the given quaternion.</returns>
		public Quaternion<T> Normalize() { return Quaternion<T>.Normalize(this); }
		/// <summary>Inverts a quaternion.</summary>
		/// <returns>The inverse of the given quaternion.</returns>
		public Quaternion<T> Invert() { return Quaternion<T>.Invert(this); }
		/// <summary>Lenearly interpolates between two quaternions.</summary>
		/// <param name="right">The ending point of the interpolation.</param>
		/// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
		/// <returns>The result of the interpolation.</returns>
		public Quaternion<T> Lerp(Quaternion<T> right, T blend) { return Quaternion<T>.Lerp(this, right, blend); }
		/// <summary>Sphereically interpolates between two quaternions.</summary>
		/// <param name="right">The ending point of the interpolation.</param>
		/// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
		/// <returns>The result of the interpolation.</returns>
		public Quaternion<T> Slerp(Quaternion<T> right, T blend) { return Quaternion<T>.Slerp(this, right, blend); }
		/// <summary>Rotates a vector by a quaternion.</summary>
		/// <param name="vector">The vector to be rotated by.</param>
		/// <returns>The result of the rotation.</returns>
		//public Vector Rotate(Vector vector) { return Quaternion<T>.Rotate(this, vector); }
		/// <summary>Does a value equality check.</summary>
		/// <param name="right">The second quaternion  to check for equality.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public bool EqualsValue(Quaternion<T> right) { return Quaternion<T>.EqualsValue(this, right); }
		/// <summary>Does a value equality check with leniency.</summary>
		/// <param name="right">The second quaternion to check for equality.</param>
		/// <param name="leniency">How much the values can vary but still be considered equal.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public bool EqualsValue(Quaternion<T> right, T leniency) { return Quaternion<T>.EqualsValue(this, right, leniency); }
		/// <summary>Checks if two matrices are equal by reverences.</summary>
		/// <param name="right">The right quaternion of the equality check.</param>
		/// <returns>True if the references are equal, false if not.</returns>
		public bool EqualsReference(Quaternion<T> right) { return Quaternion<T>.EqualsReference(this, right); }
		/// <summary>Converts a quaternion into a matrix.</summary>
		/// <returns>The resulting matrix.</returns>
    //public Matrix_Flattened ToMatrix() { return Quaternion<T>.ToMatrix(this); }

    #endregion

    #region statics

    /// <summary>Computes the length of quaternion.</summary>
		/// <param name="quaternion">The quaternion to compute the length of.</param>
		/// <returns>The length of the given quaternion.</returns>
		public static T Magnitude(Quaternion<T> quaternion)
    { return _Quaternion_Magnitude(quaternion); }
		/// <summary>Computes the length of a quaternion, but doesn't square root it
		/// for optimization possibilities.</summary>
		/// <param name="quaternion">The quaternion to compute the length squared of.</param>
		/// <returns>The squared length of the given quaternion.</returns>
		public static T MagnitudeSquared(Quaternion<T> quaternion)
		{ return Quaternion_MagnitudeSquared(quaternion); }
		/// <summary>Gets the conjugate of the quaternion.</summary>
		/// <param name="quaternion">The quaternion to conjugate.</param>
		/// <returns>The conjugate of teh given quaternion.</returns>
		public static Quaternion<T> Conjugate(Quaternion<T> quaternion)
		{ return _Quaternion_Conjugate(quaternion); }
		/// <summary>Adds two quaternions together.</summary>
		/// <param name="left">The first quaternion of the addition.</param>
		/// <param name="right">The second quaternion of the addition.</param>
		/// <returns>The result of the addition.</returns>
		public static Quaternion<T> Add(Quaternion<T> left, Quaternion<T> right)
		{ return _Quaternion_Add(left, right); }
		/// <summary>Subtracts two quaternions.</summary>
		/// <param name="left">The left quaternion of the subtraction.</param>
		/// <param name="right">The right quaternion of the subtraction.</param>
		/// <returns>The resulting quaternion after the subtraction.</returns>
		public static Quaternion<T> Subtract(Quaternion<T> left, Quaternion<T> right)
		{ return _Quaternion_Subtract(left, right); }
		/// <summary>Multiplies two quaternions together.</summary>
		/// <param name="left">The first quaternion of the multiplication.</param>
		/// <param name="right">The second quaternion of the multiplication.</param>
		/// <returns>The resulting quaternion after the multiplication.</returns>
		public static Quaternion<T> Multiply(Quaternion<T> left, Quaternion<T> right)
		{ return _Quaternion_Multiply(left, right); }
		/// <summary>Multiplies all the values of the quaternion by a scalar value.</summary>
		/// <param name="left">The quaternion of the multiplication.</param>
		/// <param name="right">The scalar of the multiplication.</param>
		/// <returns>The result of multiplying all the values in the quaternion by the scalar.</returns>
		public static Quaternion<T> Multiply(Quaternion<T> left, T right)
    { return _Quaternion_Multiply_scalar(left, right); }
    /// <summary>Pre-multiplies a 3-component vector by a quaternion.</summary>
    /// <param name="left">The quaternion to pre-multiply the vector by.</param>
    /// <param name="right">The vector to be multiplied.</param>
    /// <returns>The resulting quaternion of the multiplication.</returns>
    public static Quaternion<T> Multiply(Quaternion<T> left, Vector<T> right)
    { return _Quaternion_Multiply_Vector(left, right); }
		/// <summary>Normalizes the quaternion.</summary>
		/// <param name="quaternion">The quaternion to normalize.</param>
		/// <returns>The normalization of the given quaternion.</returns>
		public static Quaternion<T> Normalize(Quaternion<T> quaternion)
    { return _Quaternion_Normalize(quaternion); }
		/// <summary>Inverts a quaternion.</summary>
		/// <param name="quaternion">The quaternion to find the inverse of.</param>
		/// <returns>The inverse of the given quaternion.</returns>
		public static Quaternion<T> Invert(Quaternion<T> quaternion)
    { return _Quaternion_Invert(quaternion); }
		/// <summary>Lenearly interpolates between two quaternions.</summary>
		/// <param name="left">The starting point of the interpolation.</param>
		/// <param name="right">The ending point of the interpolation.</param>
		/// <param name="blend">The ratio 0.0-1.0 of how far to interpolate between the left and right quaternions.</param>
		/// <returns>The result of the interpolation.</returns>
		public static Quaternion<T> Lerp(Quaternion<T> left, Quaternion<T> right, T blend)
    { return _Quaternion_Lerp(left, right, blend); }
		/// <summary>Sphereically interpolates between two quaternions.</summary>
		/// <param name="left">The starting point of the interpolation.</param>
		/// <param name="right">The ending point of the interpolation.</param>
		/// <param name="blend">The ratio of how far to interpolate between the left and right quaternions.</param>
		/// <returns>The result of the interpolation.</returns>
		public static Quaternion<T> Slerp(Quaternion<T> left, Quaternion<T> right, T blend)
    { return _Quaternion_Slerp(left, right, blend); }
    /// <summary>Rotates a vector by a quaternion [v' = qvq'].</summary>
    /// <param name="rotation">The quaternion to rotate the vector by.</param>
    /// <param name="vector">The vector to be rotated by.</param>
    /// <returns>The result of the rotation.</returns>
    public static Vector<T> Rotate(Quaternion<T> rotation, Vector<T> vector)
    { return _Quaternion_Rotate(rotation, vector); }
		/// <summary>Does a value equality check.</summary>
		/// <param name="left">The first quaternion to check for equality.</param>
		/// <param name="right">The second quaternion  to check for equality.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public static bool EqualsValue(Quaternion<T> left, Quaternion<T> right)
    { return _Quaternion_EqualsValue(left, right); }
		/// <summary>Does a value equality check with leniency.</summary>
		/// <param name="left">The first quaternion to check for equality.</param>
		/// <param name="right">The second quaternion to check for equality.</param>
		/// <param name="leniency">How much the values can vary but still be considered equal.</param>
		/// <returns>True if values are equal, false if not.</returns>
		public static bool EqualsValue(Quaternion<T> left, Quaternion<T> right, T leniency)
    { return _Quaternion_EqualsValue_leniency(left, right, leniency); }
		/// <summary>Checks if two matrices are equal by reverences.</summary>
		/// <param name="left">The left quaternion of the equality check.</param>
		/// <param name="right">The right quaternion of the equality check.</param>
		/// <returns>True if the references are equal, false if not.</returns>
		public static bool EqualsReference(Quaternion<T> left, Quaternion<T> right)
		{ return object.ReferenceEquals(left, right); }

		///// <summary>Converts a quaternion into a matrix.</summary>
		///// <param name="quaternion">The quaternion of the conversion.</param>
		///// <returns>The resulting matrix.</returns>
		//public static Matrix_Flattened ToMatrix(Quaternion<T> quaternion)
		//{
		//	throw new NotImplementedException();
		//	//return new Matrix_Flattened(3, 3,
		//	//	quaternion.W * quaternion.W + quaternion.X * quaternion.X - quaternion.Y * quaternion.Y - quaternion.Z * quaternion.Z,
		//	//	2 * quaternion.X * quaternion.Y - 2 * quaternion.W * quaternion.Z,
		//	//	2 * quaternion.X * quaternion.Z + 2 * quaternion.W * quaternion.Y,
		//	//	2 * quaternion.X * quaternion.Y + 2 * quaternion.W * quaternion.Z,
		//	//	quaternion.W * quaternion.W - quaternion.X * quaternion.X + quaternion.Y * quaternion.Y - quaternion.Z * quaternion.Z,
		//	//	2 * quaternion.Y * quaternion.Z + 2 * quaternion.W * quaternion.X,
		//	//	2 * quaternion.X * quaternion.Z - 2 * quaternion.W * quaternion.Y,
		//	//	2 * quaternion.Y * quaternion.Z - 2 * quaternion.W * quaternion.X,
		//	//	quaternion.W * quaternion.W - quaternion.X * quaternion.X - quaternion.Y * quaternion.Y + quaternion.Z * quaternion.Z);
    //}

    #endregion

    #region overrides

    /// <summary>Converts the quaternion into a string.</summary>
		/// <returns>The resulting string after the conversion.</returns>
		public override string ToString()
		{
			// Chane this method to format it how you want...
			return base.ToString();
			//return "{ " + _x + ", " + _y + ", " + _z + ", " + _w + " }";
		}

		/// <summary>Computes a hash code from the values in this quaternion.</summary>
		/// <returns>The computed hash code.</returns>
		public override int GetHashCode()
		{
			return
				_x.GetHashCode() ^
				_y.GetHashCode() ^
				_z.GetHashCode() ^
				_w.GetHashCode();
		}

		/// <summary>Does a reference equality check.</summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public override bool Equals(object other)
		{
			if (other is Quaternion<T>)
				return Quaternion<T>.EqualsReference(this, (Quaternion<T>)other);
			return false;
		}

    #endregion
	}

  /// <summary>A matrix wrapper for T[,] to perform matrix theory in row major order. Enjoy :)</summary>
  /// <typeparam name="T">The numeric type of this Matrix.</typeparam>
  public class Matrix<T>
  {
    /// <summary>The 2-D array of this matrix.</summary>
    public readonly T[,] _matrix;

    #region runtime function mapping

    private static T _zero = Constants.Get<T>().factory(0);
    private static T _one = Constants.Get<T>().factory(1);
    private static T _two = Constants.Get<T>().factory(2);

    private static readonly LinearAlgebra.delegates.Matrix_Negate<T> _Matrix_Negate;
    private static readonly LinearAlgebra.delegates.Matrix_Add<T> _Matrix_Add;
    private static readonly LinearAlgebra.delegates.Matrix_Subtract<T> _Matrix_Subtract;
    private static readonly LinearAlgebra.delegates.Matrix_Multiply<T> _Matrix_Multiply;
    private static readonly LinearAlgebra.delegates.Matrix_Multiply_scalar<T> _Matrix_Multiply_scalar;
    private static readonly LinearAlgebra.delegates.Matrix_Multiply_vector<T> _Matrix_Multiply_vector;
    private static readonly LinearAlgebra.delegates.Matrix_Divide<T> _Matrix_Divide;
    private static readonly LinearAlgebra.delegates.Matrix_Power<T> _Matrix_Power;
    private static readonly LinearAlgebra.delegates.Matrix_Minor<T> _Matrix_Minor;
    private static readonly LinearAlgebra.delegates.Matrix_ConcatenateRowWise<T> _Matrix_ConcatenateRowWise;
    private static readonly LinearAlgebra.delegates.Matrix_Determinent<T> _Matrix_Determinent;
    private static readonly LinearAlgebra.delegates.Matrix_Echelon<T> _Matrix_Echelon;
    private static readonly LinearAlgebra.delegates.Matrix_ReducedEchelon<T> _Matrix_ReducedEchelon;
    private static readonly LinearAlgebra.delegates.Matrix_Inverse<T> _Matrix_Inverse;
    private static readonly LinearAlgebra.delegates.Matrix_Adjoint<T> _Matrix_Adjoint;
    private static readonly LinearAlgebra.delegates.Matrix_Transpose<T> _Matrix_Transpose;
    private static readonly LinearAlgebra.delegates.Matrix_DecomposeLU<T> _Matrix_DecomposeLU;
    private static readonly LinearAlgebra.delegates.Matrix_EqualsByValue<T> _Matrix_EqualsByValue;
    private static readonly LinearAlgebra.delegates.Matrix_EqualsByValue_leniency<T> _Matrix_EqualsByValue_leniency;

    static Matrix()
    {
      // Constants
      _zero = Constants.Get<T>().factory(0);
      _one = Constants.Get<T>().factory(1);
      _two = Constants.Get<T>().factory(2);

      LinearAlgebra<T> linearAlgebra = LinearAlgebra.Get<T>();
      _Matrix_Negate = linearAlgebra.Matrix_Negate;
      _Matrix_Add = linearAlgebra.Matrix_Add;
      _Matrix_Subtract = linearAlgebra.Matrix_Subtract;
      _Matrix_Multiply = linearAlgebra.Matrix_Multiply;
      _Matrix_Multiply_scalar = linearAlgebra.Matrix_Multiply_scalar;
      _Matrix_Multiply_vector = linearAlgebra.Matrix_Multiply_vector;
      _Matrix_Divide = linearAlgebra.Matrix_Divide;
      _Matrix_Power = linearAlgebra.Matrix_Power;
      _Matrix_Minor = linearAlgebra.Matrix_Minor;
      _Matrix_ConcatenateRowWise = linearAlgebra.Matrix_ConcatenateRowWise;
      _Matrix_Determinent = linearAlgebra.Matrix_Determinent;
      _Matrix_Echelon = linearAlgebra.Matrix_Echelon;
      _Matrix_ReducedEchelon = linearAlgebra.Matrix_ReducedEchelon;
      _Matrix_Inverse = linearAlgebra.Matrix_Inverse;
      _Matrix_Adjoint = linearAlgebra.Matrix_Adjoint;
      _Matrix_Transpose = linearAlgebra.Matrix_Transpose;
      _Matrix_DecomposeLU = linearAlgebra.Matrix_DecomposeLU;
      _Matrix_EqualsByValue = linearAlgebra.Matrix_EqualsByValue;
      _Matrix_EqualsByValue_leniency = linearAlgebra.Matrix_EqualsByValue_leniency;
    }

    #endregion

    #region properties

    /// <summary>The number of rows in the matrix.</summary>
    public int Rows { get { return _matrix.GetLength(0); } }
    /// <summary>The number of columns in the matrix.</summary>
    public int Columns { get { return _matrix.GetLength(1); } }
    /// <summary>Determines if the matrix is square.</summary>
    public bool IsSquare { get { return Rows == Columns; } }
    /// <summary>Determines if the matrix is a vector.</summary>
    public bool IsVector { get { return Columns == 1; } }
    /// <summary>Determines if the matrix is a 2 component vector.</summary>
    public bool Is2x1 { get { return Rows == 2 && Columns == 1; } }
    /// <summary>Determines if the matrix is a 3 component vector.</summary>
    public bool Is3x1 { get { return Rows == 3 && Columns == 1; } }
    /// <summary>Determines if the matrix is a 4 component vector.</summary>
    public bool Is4x1 { get { return Rows == 4 && Columns == 1; } }
    /// <summary>Determines if the matrix is a 2 square matrix.</summary>
    public bool Is2x2 { get { return Rows == 2 && Columns == 2; } }
    /// <summary>Determines if the matrix is a 3 square matrix.</summary>
    public bool Is3x3 { get { return Rows == 3 && Columns == 3; } }
    /// <summary>Determines if the matrix is a 4 square matrix.</summary>
    public bool Is4x4 { get { return Rows == 4 && Columns == 4; } }

    /// <summary>Standard row-major matrix indexing.</summary>
    /// <param name="row">The row index.</param>
    /// <param name="column">The column index.</param>
    /// <returns>The value at the given indeces.</returns>
    public T this[int row, int column]
    {
      get
      {
        try { return _matrix[row, column]; }
        catch { throw new Error("index out of bounds."); }
      }
      set
      {
        try { _matrix[row, column] = value; }
        catch { throw new Error("index out of bounds."); }
      }
    }

    #endregion

    #region constructors

    /// <summary>Constructs a new zero-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of row dimensions.</param>
    /// <param name="columns">The number of column dimensions.</param>
    public Matrix(int rows, int columns)
    {
      try { _matrix = new T[rows, columns]; }
      catch { throw new Error("invalid dimensions."); }
    }

    /// <summary>Wraps a float[,] inside of a matrix class. WARNING: still references that float[,].</summary>
    /// <param name="matrix">The float[,] to wrap in a matrix class.</param>
    public Matrix(T[,] matrix)
    {
      _matrix = matrix;
    }

    #endregion

    #region factories

    /// <summary>Constructs a new zero-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed zero-matrix.</returns>
    public static Matrix<T> FactoryZero(int rows, int columns)
    {
      try { return new Matrix<T>(rows, columns); }
      catch { throw new Error("invalid dimensions."); }
    }

    /// <summary>Constructs a new identity-matrix of the given dimensions.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed identity-matrix.</returns>
    public static Matrix<T> FactoryIdentity(int rows, int columns)
    {
      Matrix<T> matrix;
      try { matrix = new Matrix<T>(rows, columns); }
      catch { throw new Error("invalid dimensions."); }
      if (rows <= columns)
        for (int i = 0; i < rows; i++)
          matrix[i, i] = _one;
      else
        for (int i = 0; i < columns; i++)
          matrix[i, i] = _one;
      return matrix;
    }

    /// <summary>Constructs a new matrix where every entry is 1.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <returns>The newly constructed matrix filled with 1's.</returns>
    public static Matrix<T> FactoryOne(int rows, int columns)
    {
      Matrix<T> matrix;
      try { matrix = new Matrix<T>(rows, columns); }
      catch { throw new Error("invalid dimensions."); }
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          matrix[i, j] = _one;
      return matrix;
    }

    /// <summary>Constructs a new matrix where every entry is the same uniform value.</summary>
    /// <param name="rows">The number of rows of the matrix.</param>
    /// <param name="columns">The number of columns of the matrix.</param>
    /// <param name="uniform">The value to assign every spot in the matrix.</param>
    /// <returns>The newly constructed matrix filled with the uniform value.</returns>
    public static Matrix<T> FactoryUniform(int rows, int columns, T uniform)
    {
      Matrix<T> matrix;
      try { matrix = new Matrix<T>(rows, columns); }
      catch { throw new Error("invalid dimensions."); }
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          matrix[i, j] = uniform;
      return matrix;
    }

    /// <summary>Constructs a 2-component vector matrix with all values being 0.</summary>
    /// <returns>The constructed 2-component vector matrix.</returns>
    public static Matrix<T> Factory2x1() { return new Matrix<T>(2, 1); }
    /// <summary>Constructs a 3-component vector matrix with all values being 0.</summary>
    /// <returns>The constructed 3-component vector matrix.</returns>
    public static Matrix<T> Factory3x1() { return new Matrix<T>(3, 1); }
    /// <summary>Constructs a 4-component vector matrix with all values being 0.</summary>
    /// <returns>The constructed 4-component vector matrix.</returns>
    public static Matrix<T> Factory4x1() { return new Matrix<T>(4, 1); }

    /// <summary>Constructs a 2x2 matrix with all values being 0.</summary>
    /// <returns>The constructed 2x2 matrix.</returns>
    public static Matrix<T> Factory2x2() { return new Matrix<T>(2, 2); }
    /// <summary>Constructs a 3x3 matrix with all values being 0.</summary>
    /// <returns>The constructed 3x3 matrix.</returns>
    public static Matrix<T> Factory3x3() { return new Matrix<T>(3, 3); }
    /// <summary>Constructs a 4x4 matrix with all values being 0.</summary>
    /// <returns>The constructed 4x4 matrix.</returns>
    public static Matrix<T> Factory4x4() { return new Matrix<T>(4, 4); }

    ///// <param name="angle">Angle of rotation in radians.</param>
    //public static Matrix<T> Factory3x3RotationX(T angle)
    //{
    //  T cos = _cos(angle);
    //  T sin = _sin(angle);
    //  return new Matrix<T>(new T[,] {
    //    { _one, _zero, _zero },
    //    { _zero, cos, sin },
    //    { _zero, _negate(sin), cos }});
    //}

    ///// <param name="angle">Angle of rotation in radians.</param>
    //public static Matrix<T> Factory3x3RotationY(T angle)
    //{
    //  T cos = _cos(angle);
    //  T sin = _sin(angle);
    //  return new Matrix<T>(new T[,] {
    //    { cos, _zero, _negate(sin) },
    //    { _zero, _one, _zero },
    //    { sin, _zero, cos }});
    //}

    ///// <param name="angle">Angle of rotation in radians.</param>
    //public static Matrix<T> Factory3x3RotationZ(T angle)
    //{
    //  T cos = _cos(angle);
    //  T sin = _sin(angle);
    //  return new Matrix<T>(new T[,] {
    //    { cos, _negate(sin), _zero },
    //    { sin, cos, _zero },
    //    { _zero, _zero, _zero }});
    //}

    ///// <param name="angleX">Angle about the X-axis in radians.</param>
    ///// <param name="angleY">Angle about the Y-axis in radians.</param>
    ///// <param name="angleZ">Angle about the Z-axis in radians.</param>
    //public static Matrix<T> Factory3x3RotationXthenYthenZ(T angleX, T angleY, T angleZ)
    //{
    //  T xCos = _cos(angleX), xSin = _sin(angleX),
    //    yCos = _cos(angleY), ySin = _sin(angleY),
    //    zCos = _cos(angleZ), zSin = _sin(angleZ);
    //  return new Matrix<T>(new T[,] {
    //    { _multiply(yCos, zCos), _negate(_multiply(yCos, zSin)), ySin },
    //    { _add(_multiply(xCos, zSin), _multiply(_multiply(xSin, ySin), zCos)), _add(_multiply(xCos, zCos), _multiply(_multiply(xSin, ySin), zSin)), _negate(_multiply(xSin, yCos)) },
    //    { _subtract(_multiply(xSin, zSin), _multiply(_multiply(xCos, ySin), zCos)), _add(_multiply(xSin, zCos), _multiply(_multiply(xCos, ySin), zSin)), _multiply(xCos, yCos) }});
    //}

    ///// <param name="angleX">Angle about the X-axis in radians.</param>
    ///// <param name="angleY">Angle about the Y-axis in radians.</param>
    ///// <param name="angleZ">Angle about the Z-axis in radians.</param>
    //public static Matrix<T> Factory3x3RotationZthenYthenX(T angleX, T angleY, T angleZ)
    //{
    //  T xCos = _cos(angleX), xSin = _sin(angleX),
    //    yCos = _cos(angleY), ySin = _sin(angleY),
    //    zCos = _cos(angleZ), zSin = _sin(angleZ);
    //  return new Matrix<T>(new T[,] {
    //    { _multiply(yCos, zCos), _subtract(_multiply(_multiply(zCos, xSin), ySin), _multiply(xCos, zSin)), _add(_multiply(_multiply(xCos, zCos), ySin), _multiply(xSin, zSin)) },
    //    { _multiply(yCos, zSin), _add(_multiply(xCos, zCos), _multiply(_multiply(xSin, ySin), zSin)), _add(_multiply(_negate(zCos), xSin), _multiply(_multiply(xCos, ySin), zSin)) },
    //    { _negate(ySin), _multiply(yCos, xSin), _multiply(xCos, yCos) }});
    //}

    /// <summary>Creates a 3x3 matrix initialized with a shearing transformation.</summary>
    /// <param name="shearXbyY">The shear along the X-axis in the Y-direction.</param>
    /// <param name="shearXbyZ">The shear along the X-axis in the Z-direction.</param>
    /// <param name="shearYbyX">The shear along the Y-axis in the X-direction.</param>
    /// <param name="shearYbyZ">The shear along the Y-axis in the Z-direction.</param>
    /// <param name="shearZbyX">The shear along the Z-axis in the X-direction.</param>
    /// <param name="shearZbyY">The shear along the Z-axis in the Y-direction.</param>
    /// <returns>The constructed shearing matrix.</returns>
    public static Matrix<T> Factory3x3Shear(
      T shearXbyY, T shearXbyZ, T shearYbyX,
      T shearYbyZ, T shearZbyX, T shearZbyY)
    {
      return new Matrix<T>(new T[,] {
        { _one, shearYbyX, shearZbyX },
        { shearXbyY, _one, shearYbyZ },
        { shearXbyZ, shearYbyZ, _one }});
    }

    #endregion

    #region operators

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Matrix<T> operator -(Matrix<T> matrix)
    { return _Matrix_Negate(matrix); }
    /// <summary>Does a standard matrix addition.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after teh addition.</returns>
    public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Add(left, right); }
    /// <summary>Does a standard matrix subtraction.</summary>
    /// <param name="left">The left matrix of the subtraction.</param>
    /// <param name="right">The right matrix of the subtraction.</param>
    /// <returns>The result of the matrix subtraction.</returns>
    public static Matrix<T> operator -(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Subtract(left, right); }
    /// <summary>Multiplies a vector by a matrix.</summary>
    /// <param name="left">The matrix of the multiplication.</param>
    /// <param name="right">The vector of the multiplication.</param>
    /// <returns>The resulting vector after the multiplication.</returns>
    public static Vector<T> operator *(Matrix<T> left, Vector<T> right)
    { return _Matrix_Multiply_vector(left._matrix, right._vector); }
    /// <summary>Does a standard matrix multiplication.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix after the multiplication.</returns>
    public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Multiply(left._matrix, right._matrix); }
    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have its values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Matrix<T> operator *(Matrix<T> left, T right)
    { return _Matrix_Multiply_scalar(left, right); }
    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The scalar to multiply the values by.</param>
    /// <param name="right">The matrix to have its values multiplied.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Matrix<T> operator *(T left, Matrix<T> right)
    { return _Matrix_Multiply_scalar(right, left); }
    /// <summary>Divides all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have its values divided.</param>
    /// <param name="right">The scalar to divide the values by.</param>
    /// <returns>The resulting matrix after the divisions.</returns>
    public static Matrix<T> operator /(Matrix<T> left, T right)
    { return _Matrix_Divide(left, right); }
    /// <summary>Applies a power to a matrix.</summary>
    /// <param name="left">The matrix to apply a power to.</param>
    /// <param name="right">The power to apply to the matrix.</param>
    /// <returns>The result of the power operation.</returns>
    public static Matrix<T> operator ^(Matrix<T> left, int right)
    { return _Matrix_Power(left, right); }
    /// <summary>Checks for equality by value.</summary>
    /// <param name="left">The left matrix of the equality check.</param>
    /// <param name="right">The right matrix of the equality check.</param>
    /// <returns>True if the values of the matrices are equal, false if not.</returns>
    public static bool operator ==(Matrix<T> left, Matrix<T> right)
    { return _Matrix_EqualsByValue(left, right); }
    /// <summary>Checks for false-equality by value.</summary>
    /// <param name="left">The left matrix of the false-equality check.</param>
    /// <param name="right">The right matrix of the false-equality check.</param>
    /// <returns>True if the values of the matrices are not equal, false if they are.</returns>
    public static bool operator !=(Matrix<T> left, Matrix<T> right)
    { return !_Matrix_EqualsByValue(left, right); }
    /// <summary>Automatically converts a matrix into a T[,] if necessary.</summary>
    /// <param name="matrix">The matrix to convert to a T[,].</param>
    /// <returns>The reference to the T[,] representing the matrix.</returns>
    public static implicit operator T[,](Matrix<T> matrix)
    { return matrix._matrix; }
    /// <summary>Automatically converts a float[,] into a matrix if necessary.</summary>
    /// <param name="matrix">The float[,] to convert to a matrix.</param>
    /// <returns>The reference to the matrix representing the T[,].</returns>
    public static implicit operator Matrix<T>(T[,] matrix)
    { return new Matrix<T>(matrix); }

    #endregion

    #region instance

    /// <summary>Negates all the values in this matrix.</summary>
    /// <returns>The resulting matrix after the negations.</returns>
    private Matrix<T> Negate()
    { return _Matrix_Negate(this); }
    /// <summary>Does a standard matrix addition.</summary>
    /// <param name="right">The matrix to add to this matrix.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    private Matrix<T> Add(Matrix<T> right)
    { return _Matrix_Add(this, right); }
    /// <summary>Does a standard matrix multiplication (triple for loop).</summary>
    /// <param name="right">The matrix to multiply this matrix by.</param>
    /// <returns>The resulting matrix after the multiplication.</returns>
    private Matrix<T> Multiply(Matrix<T> right)
    { return _Matrix_Multiply(this, right); }
    /// <summary>Multiplies all the values in this matrix by a scalar.</summary>
    /// <param name="right">The scalar to multiply all the matrix values by.</param>
    /// <returns>The retulting matrix after the multiplications.</returns>
    private Matrix<T> Multiply(T right)
    { return _Matrix_Multiply_scalar(this, right); }
    /// <summary>Divides all the values in this matrix by a scalar.</summary>
    /// <param name="right">The scalar to divide the matrix values by.</param>
    /// <returns>The resulting matrix after teh divisions.</returns>
    private Matrix<T> Divide(T right)
    { return _Matrix_Divide(this, right); }
    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="row">The restricted row of the minor.</param>
    /// <param name="column">The restricted column of the minor.</param>
    /// <returns>The minor from the row/column restrictions.</returns>
    public Matrix<T> Minor(int row, int column)
    { return _Matrix_Minor(this, row, column); }
    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="right">The matrix to combine with on the right side.</param>
    /// <returns>The resulting row-wise concatination.</returns>
    public Matrix<T> ConcatenateRowWise(Matrix<T> right)
    { return _Matrix_ConcatenateRowWise(this, right); }
    /// <summary>Computes the determinent if this matrix is square.</summary>
    /// <returns>The computed determinent if this matrix is square.</returns>
    public T Determinent()
    { return _Matrix_Determinent(this); }
    /// <summary>Computes the echelon form of this matrix (aka REF).</summary>
    /// <returns>The computed echelon form of this matrix (aka REF).</returns>
    public Matrix<T> Echelon()
    { return _Matrix_Echelon(this); }
    /// <summary>Computes the reduced echelon form of this matrix (aka RREF).</summary>
    /// <returns>The computed reduced echelon form of this matrix (aka RREF).</returns>
    public Matrix<T> ReducedEchelon()
    { return _Matrix_ReducedEchelon(this); }
    /// <summary>Computes the inverse of this matrix.</summary>
    /// <returns>The inverse of this matrix.</returns>
    public Matrix<T> Inverse()
    { return _Matrix_Inverse(this); }
    /// <summary>Gets the adjoint of this matrix.</summary>
    /// <returns>The adjoint of this matrix.</returns>
    public Matrix<T> Adjoint()
    { return _Matrix_Adjoint(this); }
    /// <summary>Transposes this matrix.</summary>
    /// <returns>The transpose of this matrix.</returns>
    public Matrix<T> Transpose()
    { return _Matrix_Transpose(this); }
    /// <summary>Copies this matrix.</summary>
    /// <returns>The copy of this matrix.</returns>
    public Matrix<T> Clone()
    { return Matrix<T>.Clone(this); }

    #endregion

    #region static

    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static T[,] Negate(T[,] matrix)
    { return _Matrix_Negate(matrix); }
    /// <summary>Negates all the values in a matrix.</summary>
    /// <param name="matrix">The matrix to have its values negated.</param>
    /// <returns>The resulting matrix after the negations.</returns>
    public static Matrix<T> Negate(Matrix<T> matrix)
    { return _Matrix_Negate(matrix._matrix); }
    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static T[,] Add(T[,] left, T[,] right)
    { return _Matrix_Add(left, right); }
    /// <summary>Does standard addition of two matrices.</summary>
    /// <param name="left">The left matrix of the addition.</param>
    /// <param name="right">The right matrix of the addition.</param>
    /// <returns>The resulting matrix after the addition.</returns>
    public static Matrix<T> Add(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Add(left, right); }
    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static T[,] Subtract(T[,] left, T[,] right)
    { return _Matrix_Subtract(left, right); }
    /// <summary>Subtracts a scalar from all the values in a matrix.</summary>
    /// <param name="left">The matrix to have the values subtracted from.</param>
    /// <param name="right">The scalar to subtract from all the matrix values.</param>
    /// <returns>The resulting matrix after the subtractions.</returns>
    public static Matrix<T> Subtract(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Subtract(left._matrix, right._matrix); }
    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static T[,] Multiply(T[,] left, T[,] right)
    { return _Matrix_Multiply(left, right); }
    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Matrix<T> Multiply(Matrix<T> left, Matrix<T> right)
    { return _Matrix_Multiply(left._matrix, right._matrix); }
    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static T[] Multiply(T[,] left, T[] right)
    { return _Matrix_Multiply_vector(left, right); }
    /// <summary>Does a standard (triple for looped) multiplication between matrices.</summary>
    /// <param name="left">The left matrix of the multiplication.</param>
    /// <param name="right">The right matrix of the multiplication.</param>
    /// <returns>The resulting matrix of the multiplication.</returns>
    public static Vector<T> Multiply(Matrix<T> left, Vector<T> right)
    { return _Matrix_Multiply_vector(left._matrix, right._vector); }
    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static T[,] Multiply(T[,] left, T right)
    { return _Matrix_Multiply_scalar(left, right); }
    /// <summary>Multiplies all the values in a matrix by a scalar.</summary>
    /// <param name="left">The matrix to have the values multiplied.</param>
    /// <param name="right">The scalar to multiply the values by.</param>
    /// <returns>The resulting matrix after the multiplications.</returns>
    public static Matrix<T> Multiply(Matrix<T> left, T right)
    { return _Matrix_Multiply_scalar(left._matrix, right); }
    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static T[,] Power(T[,] matrix, int power)
    { return _Matrix_Power(matrix, power); }
    /// <summary>Applies a power to a square matrix.</summary>
    /// <param name="matrix">The matrix to be powered by.</param>
    /// <param name="power">The power to apply to the matrix.</param>
    /// <returns>The resulting matrix of the power operation.</returns>
    public static Matrix<T> Power(Matrix<T> matrix, int power)
    { return _Matrix_Power(matrix._matrix, power); }
    /// <summary>Divides all the values in the matrix by a scalar.</summary>
    /// <param name="matrix">The matrix to divide the values of.</param>
    /// <param name="right">The scalar to divide all the matrix values by.</param>
    /// <returns>The resulting matrix with the divided values.</returns>
    public static T[,] Divide(T[,] matrix, T right)
    { return _Matrix_Divide(matrix, right); }
    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static T[,] Minor(T[,] matrix, int row, int column)
    { return _Matrix_Minor(matrix, row, column); }
    /// <summary>Gets the minor of a matrix.</summary>
    /// <param name="matrix">The matrix to get the minor of.</param>
    /// <param name="row">The restricted row to form the minor.</param>
    /// <param name="column">The restricted column to form the minor.</param>
    /// <returns>The minor of the matrix.</returns>
    public static Matrix<T> Minor(Matrix<T> matrix, int row, int column)
    { return _Matrix_Minor(matrix._matrix, row, column); }
    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static T[,] ConcatenateRowWise(T[,] left, T[,] right)
    { return _Matrix_ConcatenateRowWise(left, right); }
    /// <summary>Combines two matrices from left to right 
    /// (result.Rows = left.Rows && result.Columns = left.Columns + right.Columns).</summary>
    /// <param name="left">The left matrix of the concatenation.</param>
    /// <param name="right">The right matrix of the concatenation.</param>
    /// <returns>The resulting matrix of the concatenation.</returns>
    public static Matrix<T> ConcatenateRowWise(Matrix<T> left, Matrix<T> right)
    { return _Matrix_ConcatenateRowWise(left._matrix, right._matrix); }
    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static T Determinent(T[,] matrix)
    { return _Matrix_Determinent(matrix); }
    /// <summary>Calculates the determinent of a square matrix.</summary>
    /// <param name="matrix">The matrix to calculate the determinent of.</param>
    /// <returns>The determinent of the matrix.</returns>
    public static T Determinent(Matrix<T> matrix)
    { return _Matrix_Determinent(matrix._matrix); }
    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static T[,] Echelon(T[,] matrix)
    { return _Matrix_Echelon(matrix); }
    /// <summary>Calculates the echelon of a matrix (aka REF).</summary>
    /// <param name="matrix">The matrix to calculate the echelon of (aka REF).</param>
    /// <returns>The echelon of the matrix (aka REF).</returns>
    public static Matrix<T> Echelon(Matrix<T> matrix)
    { return _Matrix_Echelon(matrix._matrix); }
    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static T[,] ReducedEchelon(T[,] matrix)
    { return _Matrix_ReducedEchelon(matrix); }
    /// <summary>Calculates the echelon of a matrix and reduces it (aka RREF).</summary>
    /// <param name="matrix">The matrix matrix to calculate the reduced echelon of (aka RREF).</param>
    /// <returns>The reduced echelon of the matrix (aka RREF).</returns>
    public static Matrix<T> ReducedEchelon(Matrix<T> matrix)
    { return _Matrix_ReducedEchelon(matrix._matrix); }
    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static T[,] Inverse(T[,] matrix)
    { return _Matrix_Inverse(matrix); }
    /// <summary>Calculates the inverse of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the inverse of.</param>
    /// <returns>The inverse of the matrix.</returns>
    public static Matrix<T> Inverse(Matrix<T> matrix)
    { return _Matrix_Inverse(matrix._matrix); }
    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static T[,] Adjoint(T[,] matrix)
    { return _Matrix_Adjoint(matrix); }
    /// <summary>Calculates the adjoint of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate the adjoint of.</param>
    /// <returns>The adjoint of the matrix.</returns>
    public static Matrix<T> Adjoint(Matrix<T> matrix)
    { return _Matrix_Adjoint(matrix._matrix); }
    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static T[,] Transpose(T[,] matrix)
    { return _Matrix_Transpose(matrix); }
    /// <summary>Returns the transpose of a matrix.</summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transpose of the matrix.</returns>
    public static Matrix<T> Transpose(Matrix<T> matrix)
    { return _Matrix_Transpose(matrix._matrix); }
    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(T[,] matrix, out T[,] lower, out T[,] upper)
    { _Matrix_DecomposeLU(matrix, out lower, out upper); }
    /// <summary>Decomposes a matrix into lower-upper reptresentation.</summary>
    /// <param name="matrix">The matrix to decompose.</param>
    /// <param name="lower">The computed lower triangular matrix.</param>
    /// <param name="upper">The computed upper triangular matrix.</param>
    public static void DecomposeLU(Matrix<T> matrix, out Matrix<T> lower, out Matrix<T> upper)
    {
      T[,] lower_array, upper_array;
      _Matrix_DecomposeLU(matrix, out lower_array, out upper_array);
      lower = new Matrix<T>(lower_array);
      upper = new Matrix<T>(upper_array);
    }
    /// <summary>Creates a copy of a matrix.</summary>
    /// <param name="matrix">The matrix to copy.</param>
    /// <returns>A copy of the matrix.</returns>
    public static Matrix<T> Clone(T[,] matrix)
    { return new Matrix<T>(matrix.Clone() as T[,]); }
    /// <summary>Does a value equality check.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsByValue(T[,] left, T[,] right)
    { return _Matrix_EqualsByValue(left, right);  }
    /// <summary>Does a value equality check with leniency.</summary>
    /// <param name="left">The first matrix to check for equality.</param>
    /// <param name="right">The second matrix to check for equality.</param>
    /// <param name="leniency">How much the values can vary but still be considered equal.</param>
    /// <returns>True if values are equal, false if not.</returns>
    public static bool EqualsByValue(T[,] left, T[,] right, T leniency)
    { return _Matrix_EqualsByValue_leniency(left, right, leniency); }
    /// <summary>Checks if two matrices are equal by reverences.</summary>
    /// <param name="left">The left matric of the equality check.</param>
    /// <param name="right">The right matrix of the equality check.</param>
    /// <returns>True if the references are equal, false if not.</returns>
    public static bool EqualsByReference(T[,] left, T[,] right)
    { return object.ReferenceEquals(left, right); }
    /// <summary>Checks if two matrices are equal by reverences.</summary>
    /// <param name="left">The left matric of the equality check.</param>
    /// <param name="right">The right matrix of the equality check.</param>
    /// <returns>True if the references are equal, false if not.</returns>
    public static bool EqualsByReference(Matrix<T> left, Matrix<T> right)
    { return Matrix<T>.ReferenceEquals(left._matrix, right._matrix); }

    #endregion

    #region overrides

    /// <summary>Prints out a string representation of this matrix.</summary>
    /// <returns>A string representing this matrix.</returns>
    public override string ToString()
    { return base.ToString(); }
    /// <summary>Computes a hash code from the values of this matrix.</summary>
    /// <returns>A hash code for the matrix.</returns>
    public override int GetHashCode()
    { return this._matrix.GetHashCode(); }
    /// <summary>Does an equality check by reference.</summary>
    /// <param name="right">The object to compare to.</param>
    /// <returns>True if the references are equal, false if not.</returns>
    public override bool Equals(object right)
    { if (!(right is Matrix<T>)) return false;
			return Matrix<T>.EqualsByReference(this, (Matrix<T>)right); }
    #endregion
  }
}
