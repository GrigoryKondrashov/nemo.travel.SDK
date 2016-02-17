﻿using System.Runtime.Serialization;

namespace GeneralEntities.Lib
{
	/// <summary>
	/// Реквизиты аутентификации
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class RequestRequisites
	{
		/// <summary>
		/// Логин
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Login { get; set; }

		/// <summary>
		/// Пароль
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Password { get; set; }

		/// <summary>
		/// Ключ авторизации
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string AuthToken { get; set; }


		public RequestRequisites()
		{
		}

		public RequestRequisites(string token)
		{
			AuthToken = token;
		}

		public RequestRequisites(string login, string password)
		{
			Login = login;
			Password = password;
		}


		public bool Validate()
		{
			return !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password)
				|| !string.IsNullOrEmpty(AuthToken);
		}
	}
}
