﻿using System.Reflection;
using TSharp.Core.Osgi.Internal;

namespace TSharp.Core.Osgi
{
	/// <summary>
	/// 扩展点
	/// <para>2010/12/24</para>
	/// 	<para>THINKPADT61</para>
	/// 	<para>tangjingbo</para>
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute.</typeparam>
	public abstract class ExtensionPoint<TAttribute> : ExtensionPoint
		where TAttribute : ExtensionAttribute
	{
		/// <summary>
		/// 注册扩展
		/// </summary>
		/// <param name="assembly">程序集.</param>
		/// <param name="attribute">扩展.</param>
		protected abstract void Register(Assembly assembly, TAttribute attribute);

		/// <summary>
		/// 注销扩展
		/// </summary>
		/// <param name="assembly">程序集.</param>
		/// <param name="attribute">扩展.</param>
        protected abstract void UnRegister(Assembly assembly, TAttribute attribute);

		/// <summary>
		/// 注册扩展
		/// </summary>
		/// <param name="assembly">程序集.</param>
		/// <param name="attribute">扩展.</param>
		internal override void InnerRegister(Assembly assembly, ExtensionAttribute attribute)
		{
			Register(assembly, (TAttribute) attribute);
		}

		/// <summary>
		/// 注销扩展
		/// </summary>
		/// <param name="assembly">程序集.</param>
		/// <param name="attribute">扩展.</param>
		internal override void InnerUnRegister(Assembly assembly, ExtensionAttribute attribute)
		{
			UnRegister(assembly, (TAttribute) attribute);
		}
	}
}