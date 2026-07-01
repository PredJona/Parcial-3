from pathlib import Path
import textwrap

from reportlab.lib import colors
from reportlab.lib.pagesizes import A4, landscape
from reportlab.pdfbase.pdfmetrics import stringWidth
from reportlab.pdfgen import canvas


ROOT = Path(__file__).resolve().parents[1]
DELIVERY_ROOT = ROOT.parent
OUTPUT = DELIVERY_ROOT / "CodigoPDF" / "CodigoFuente_EduRegistro.pdf"

PAGE_SIZE = landscape(A4)
MARGIN_X = 34
MARGIN_TOP = 36
MARGIN_BOTTOM = 30
FONT_CODE = "Courier"
FONT_TEXT = "Helvetica"
FONT_BOLD = "Helvetica-Bold"
CODE_SIZE = 6.6
LINE_HEIGHT = 8.4


ORDER_PREFIXES = [
    "Program.cs",
    "Models/",
    "Services/",
    "Helpers/",
    "Forms/FrmRegistroEstudiantes.cs",
    "Forms/FrmRegistroEstudiantes.Designer.cs",
    "Forms/FrmAcercaDe.cs",
    "Forms/FrmAcercaDe.Designer.cs",
]


def relative_name(path):
    return path.relative_to(ROOT).as_posix()


def sort_key(path):
    name = relative_name(path)
    for index, prefix in enumerate(ORDER_PREFIXES):
        if name == prefix or name.startswith(prefix):
            return index, name
    return len(ORDER_PREFIXES), name


def collect_sources():
    return sorted(
        [
            path
            for path in ROOT.rglob("*.cs")
            if "bin" not in path.parts and "obj" not in path.parts
        ],
        key=sort_key,
    )


def clean_line(value):
    return value.rstrip("\n").rstrip("\r").replace("\t", "    ")


def max_chars_for_width(width):
    char_width = stringWidth("M", FONT_CODE, CODE_SIZE)
    return max(40, int(width / char_width))


def draw_footer(pdf, page_number):
    width, _ = PAGE_SIZE
    pdf.setFont(FONT_TEXT, 8)
    pdf.setFillColor(colors.HexColor("#475569"))
    pdf.drawRightString(width - MARGIN_X, 16, f"Pagina {page_number}")


def draw_header(pdf, title):
    width, height = PAGE_SIZE
    pdf.setFillColor(colors.HexColor("#16398F"))
    pdf.rect(0, height - 28, width, 28, stroke=0, fill=1)
    pdf.setFont(FONT_BOLD, 10)
    pdf.setFillColor(colors.white)
    pdf.drawString(MARGIN_X, height - 19, title)


def new_page(pdf, page_number, title):
    draw_header(pdf, title)
    draw_footer(pdf, page_number)
    return PAGE_SIZE[1] - MARGIN_TOP - 14


def draw_cover(pdf, sources):
    width, height = PAGE_SIZE
    pdf.setFillColor(colors.HexColor("#16398F"))
    pdf.rect(0, height - 96, width, 96, stroke=0, fill=1)
    pdf.setFillColor(colors.white)
    pdf.setFont(FONT_BOLD, 24)
    pdf.drawString(MARGIN_X, height - 46, "EduRegistro")
    pdf.setFont(FONT_TEXT, 13)
    pdf.drawString(MARGIN_X, height - 70, "Codigo fuente comentado - Parcial No. 3")

    y = height - 130
    pdf.setFillColor(colors.HexColor("#0F172A"))
    pdf.setFont(FONT_BOLD, 14)
    pdf.drawString(MARGIN_X, y, "Proyecto: P3_LPI_Eq03_RegEst")
    y -= 24
    pdf.setFont(FONT_TEXT, 10)
    pdf.drawString(MARGIN_X, y, "Incluye archivos .cs del modelo, servicios, helpers, formularios y Designer.")
    y -= 28
    pdf.setFont(FONT_BOLD, 11)
    pdf.drawString(MARGIN_X, y, "Archivos incluidos:")
    y -= 18
    pdf.setFont(FONT_TEXT, 8.5)

    for source in sources:
        if y < MARGIN_BOTTOM + 20:
            draw_footer(pdf, 1)
            pdf.showPage()
            y = new_page(pdf, 2, "EduRegistro - archivos incluidos")
            pdf.setFont(FONT_TEXT, 8.5)
            pdf.setFillColor(colors.HexColor("#0F172A"))
        pdf.drawString(MARGIN_X + 12, y, "- " + relative_name(source))
        y -= 12

    draw_footer(pdf, 1)


def draw_code_file(pdf, source, page_number):
    width, height = PAGE_SIZE
    title = "Codigo fuente - " + relative_name(source)
    y = new_page(pdf, page_number, title)

    pdf.setFont(FONT_BOLD, 12)
    pdf.setFillColor(colors.HexColor("#0F172A"))
    pdf.drawString(MARGIN_X, y, relative_name(source))
    y -= 18

    usable_width = width - (MARGIN_X * 2)
    line_number_width = stringWidth("0000 | ", FONT_CODE, CODE_SIZE)
    text_width = usable_width - line_number_width
    max_chars = max_chars_for_width(text_width)

    pdf.setFont(FONT_CODE, CODE_SIZE)
    pdf.setFillColor(colors.HexColor("#111827"))

    for number, raw_line in enumerate(source.read_text(encoding="utf-8").splitlines(), start=1):
        line = clean_line(raw_line)
        wrapped = textwrap.wrap(
            line,
            width=max_chars,
            replace_whitespace=False,
            drop_whitespace=False,
        ) or [""]

        for part_index, part in enumerate(wrapped):
            if y < MARGIN_BOTTOM + LINE_HEIGHT:
                pdf.showPage()
                page_number += 1
                y = new_page(pdf, page_number, title)
                pdf.setFont(FONT_CODE, CODE_SIZE)
                pdf.setFillColor(colors.HexColor("#111827"))

            prefix = f"{number:04d} | " if part_index == 0 else "     | "
            pdf.drawString(MARGIN_X, y, prefix + part)
            y -= LINE_HEIGHT

    return page_number


def main():
    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    sources = collect_sources()
    pdf = canvas.Canvas(str(OUTPUT), pagesize=PAGE_SIZE)
    pdf.setTitle("Codigo fuente EduRegistro")
    pdf.setAuthor("P3_LPI_Eq03_RegEst")

    draw_cover(pdf, sources)
    page_number = 2

    for source in sources:
        pdf.showPage()
        page_number = draw_code_file(pdf, source, page_number)
        page_number += 1

    pdf.save()
    print(OUTPUT)


if __name__ == "__main__":
    main()
