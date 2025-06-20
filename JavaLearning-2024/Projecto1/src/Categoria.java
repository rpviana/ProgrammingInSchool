public class Categoria {

    private String slug;
    private String Categoria;
    private Categoria pai;

    public String getSlugNome() {
        return slug;
    }
    public void setSlugNome(String Slug) {
        slug = Slug;
    }

    public String getNomeCategoria() {
        return Categoria;
    }
    public void setNomeCategoria(String Categoria) {
        this.Categoria = Categoria;
    }

    public Categoria getPai() {
        return pai;
    }
    public void setPai(Categoria pai) {
        this.pai = pai;
    }

    /* construtor vazio */
    public Categoria() {
        this.slug = "";
        this.Categoria = "";
        this.pai = null;
    }

    /* construtor completo */
    public Categoria(String Slug, String Categoria, Categoria pai) {
        slug = Slug;
        this.Categoria = Categoria;
        this.pai = pai;
 
    }

    @Override
    public String toString() {
        return "Categoria [Slug=" + slug + ", Categoria=" + Categoria + ", pai=" + pai + "]";
    }

    
}
