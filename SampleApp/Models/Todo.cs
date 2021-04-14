using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    // クラス名は必ず単数形で。（複数形に変換されてテーブルが生成される）
    public class Todo
    {
        // 作成されたテーブルはプロパティ名と同名の列が生成される。
        // Idという項目は自動的に主キーになる
        public int Id { get; set; }

        [DisplayName("概要")]
        public string Sumary { get; set; }

        [DisplayName("詳細")]
        public string Detail { get; set; }

        [DisplayName("期限")]
        public DateTime Limit { get; set; }

        [DisplayName("完了")]
        public bool Done { get; set; }
    }
}