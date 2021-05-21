namespace Proseminarium1.komponenty
{
    partial class Kłódkazamk
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.kłódkaotwr1 = new Proseminarium1.komponenty.Kłódkaotwr();
            this.SuspendLayout();
            // 
            // kłódkaotwr1
            // 
            this.kłódkaotwr1.AllowDrop = true;
            this.kłódkaotwr1.Location = new System.Drawing.Point(0, 0);
            this.kłódkaotwr1.Name = "kłódkaotwr1";
            this.kłódkaotwr1.Size = new System.Drawing.Size(0, 0);
            this.kłódkaotwr1.TabIndex = 0;
            this.kłódkaotwr1.Text = "kłódkaotwr1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kłódkaotwr kłódkaotwr1;
    }
}
