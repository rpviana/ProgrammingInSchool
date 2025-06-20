import java.time.LocalDate;

public class Artigo {
    private String titulo;
    private Autor autor;
    private LocalDate dataPublicacao;
    private Categoria categoria;

    public String getTitulo() {
        return titulo;
    }
    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }
    public Autor getAutor() {
        return autor;
    }
    public void setAutor(Autor autor) {
        this.autor = autor;
    }
    public LocalDate getDataPublicacao() {
        return dataPublicacao;
    }
    public void setDataPublicacao(LocalDate dataPublicacao) {
        this.dataPublicacao = dataPublicacao;
    }
    public Categoria getCategoria() {
        return categoria;
    }
    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    
    public Artigo(String titulo, Autor autor, LocalDate dataPublicacao, Categoria categoria) {
        this.titulo = titulo;
        this.autor = autor;
        this.dataPublicacao = dataPublicacao;
        this.categoria = categoria;
    }

    @Override
    public String toString() {
        return "Artigo [titulo=" + titulo + ", autor=" + autor + ", dataPublicacao=" + dataPublicacao + ", categoria="
                + categoria + "]";
    }
    

    
}

