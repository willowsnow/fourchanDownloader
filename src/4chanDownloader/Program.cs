﻿using CommandLine;

namespace fourchanDownloader
{
	class Program
	{
		static void Main(string[] args)
		{
			Parser.Default.ParseArguments<ArgModel>(args)
				.WithParsed(opts =>
				{
					ThreadDownloader td = new ThreadDownloader(opts.Url, opts.PreserveFileName, opts.Threads);
					td.DownloadThread().Wait();
				});
		}
	}
}
